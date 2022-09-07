using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.RoleAgg;
using OuroFramework.Application;
using OuroFramework.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace AccountManagement.Infrastructure.Repositories
{
    public class RoleRepository : RepositoryBase<int, Role>, IRoleRepository
    {
        private readonly AccountContext _context;
        public RoleRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public List<RoleViewModel> GetAll()
        {
            return _context.Roles.Select(p => new RoleViewModel
            {
                Id = p.Id,
                Title = p.Title,
                CreationTime = p.CreationTime.ToFarsi()
            }).ToList();
        }

        public EditRole GetDetails(int id)
        {
            return _context.Roles.Select(p => new EditRole
            {
                Id = p.Id,
                Title = p.Title
            }).FirstOrDefault(p => p.Id == id);
        }
    }
}
