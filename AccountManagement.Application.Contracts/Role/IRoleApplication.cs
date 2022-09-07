using OuroFramework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contracts.Role
{
    public interface IRoleApplication
    {
        OperationResult Create(CreateRole command);
        OperationResult Edit(EditRole command);
        EditRole GetDetails(int id);
        List<RoleViewModel> GetAll();
    }
}
