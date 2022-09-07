using AccountManagement.Application.Contracts.Role;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace AccountManagement.Domain.RoleAgg
{
    public interface IRoleRepository : IRepositoryBase<int, Role>
    {
        EditRole GetDetails(int id);
        List<RoleViewModel> GetAll();
    }
}
