using DiscountManagement.Application.Contracts.CustomerDiscount;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public interface ICustomerDiscountRepository : IRepositoryBase<int, CustomerDiscount>
    {
        EditCustomerDiscount GetDetails(int id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
