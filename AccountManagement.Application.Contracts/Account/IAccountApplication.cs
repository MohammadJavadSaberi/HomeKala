using OuroFramework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contracts.Account
{
    public interface IAccountApplication
    {
        OperationResult Create(CreateAccount command);
        OperationResult Edit(EditAccount command);
        OperationResult Login(Login command);
        OperationResult Logout();
        OperationResult ChangePassword(ChangePassword command);
        EditAccount GetDetails(int id);
        List<AccountViewModel> Search(AccountSearchModel searchModel);
    }
}
