using AccountManagement.Application.Contracts.Account;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace AccountManagement.Domain.AccountAgg
{
    public interface IAccountRepository : IRepositoryBase<int, Account>
    {
        Account GetBy(string username);
        EditAccount GetDetails(int id);
        List<AccountViewModel> Search(AccountSearchModel searchModel);
    }
}
