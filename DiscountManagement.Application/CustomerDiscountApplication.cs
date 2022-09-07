using DiscountManagement.Application.Contracts.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;
using OuroFramework.Application;
using System.Collections.Generic;

namespace DiscountManagement.Application
{
    public class CustomerDiscountApplication : ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _customerDiscountRepository;
        public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
        {
            _customerDiscountRepository = customerDiscountRepository;
        }

        public OperationResult Create(CreateCustomerDiscount command)
        {
            var operation = new OperationResult();
            if (_customerDiscountRepository.Exists(p => p.ProductId == command.ProductId && p.DiscountRate == command.DiscountRate))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var customerDiscount = new CustomerDiscount(command.DiscountRate, command.ProductId, command.StartTime.ToGeorgianDateTime(), command.EndTime.ToGeorgianDateTime(), command.Reason);

            _customerDiscountRepository.Create(customerDiscount);
            _customerDiscountRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditCustomerDiscount command)
        {
            var operation = new OperationResult();
            var customerDiscount = _customerDiscountRepository.Get(command.Id);
            if (customerDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (_customerDiscountRepository.Exists(p => p.ProductId == command.ProductId && p.DiscountRate == command.DiscountRate && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            customerDiscount.Edit(command.DiscountRate, command.ProductId, command.StartTime.ToGeorgianDateTime(), command.EndTime.ToGeorgianDateTime(), command.Reason);

            _customerDiscountRepository.Save();
            return operation.Succedded();
        }

        public EditCustomerDiscount GetDetails(int id)
        {
            return _customerDiscountRepository.GetDetails(id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
        {
            return _customerDiscountRepository.Search(searchModel);
        }
        public OperationResult Active(int id)
        {
            var operation = new OperationResult();

            var customerDiscount = _customerDiscountRepository.Get(id);
            if (customerDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            customerDiscount.Active();

            _customerDiscountRepository.Save();
            return operation.Succedded();
        }
        public OperationResult DeActive(int id)
        {
            var operation = new OperationResult();

            var customerDiscount = _customerDiscountRepository.Get(id);
            if (customerDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            customerDiscount.DeActive();

            _customerDiscountRepository.Save();
            return operation.Succedded();
        }
    }
}
