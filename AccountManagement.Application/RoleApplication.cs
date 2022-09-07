using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.RoleAgg;
using OuroFramework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleRepository _roleRepository;
        public RoleApplication(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public OperationResult Create(CreateRole command)
        {
            var operation = new OperationResult();
            if (_roleRepository.Exists(p => p.Title == command.Title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var role = new Role(command.Title,new List<Premission>());

            _roleRepository.Create(role);
            _roleRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditRole command)
        {
            var operation = new OperationResult();
            var role = _roleRepository.Get(command.Id);
            if (role == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (_roleRepository.Exists(p => p.Title == command.Title && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            role.Edit(command.Title, new List<Premission>());
            _roleRepository.Save();
            return operation.Succedded();
        }

        public List<RoleViewModel> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public EditRole GetDetails(int id)
        {
            return _roleRepository.GetDetails(id);
        }
    }
}
