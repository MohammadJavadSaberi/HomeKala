using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;
using OuroFramework.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace AccountManagement.Infrastructure.Repositories
{
    public class AccountRepository : RepositoryBase<int, Account>, IAccountRepository
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public Account GetBy(string username)
        {
            return _context.Accounts.FirstOrDefault(p => p.UserName == username);
        }

        public EditAccount GetDetails(int id)
        {
            return _context.Accounts.Select(p => new EditAccount
            {
                Id = p.Id,
                FullName = p.FullName,
                UserName = p.UserName,
                PassWord = p.PassWord,
                Mobile = p.Mobile,
                //ProfilePicture = p.ProfilePicture,
                RoleId = p.RoleId
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _context.Accounts.Include(p => p.Role).Select(p => new AccountViewModel
            {
                Id = p.Id,
                FullName = p.FullName,
                UserName = p.UserName,
                Mobile = p.Mobile,
                ProfilePicture = p.ProfilePicture,
                Role = p.Role.Title,
                RoleId = p.RoleId
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(p => p.FullName.Contains(searchModel.FullName));

            if (!string.IsNullOrWhiteSpace(searchModel.UserName))
                query = query.Where(p => p.UserName.Contains(searchModel.UserName));

            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(p => p.Mobile.Contains(searchModel.Mobile));

            if (searchModel.RoleId > 0)
                query = query.Where(p => p.RoleId == searchModel.RoleId);

            return query.OrderByDescending(p => p.Id).ToList();
        }
    }
}
