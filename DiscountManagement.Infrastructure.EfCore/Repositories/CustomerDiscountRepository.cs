using DiscountManagement.Application.Contracts.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;
using OuroFramework.Application;
using OuroFramework.Infrastructure;
using ShopManagement.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace DiscountManagement.Infrastructure.EfCore.Repositories
{
    public class CustomerDiscountRepository : RepositoryBase<int, CustomerDiscount>, ICustomerDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;
        public CustomerDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditCustomerDiscount GetDetails(int id)
        {
            return _context.CustomerDiscounts.Select(p => new EditCustomerDiscount
            {
                Id = p.Id,
                DiscountRate = p.DiscountRate,
                ProductId = p.ProductId,
                StartTime = p.StartTime.ToString(),
                EndTime = p.EndTime.ToString(),
                Reason = p.Reason
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
        {
            var products = _shopContext.Products.Select(p => new { p.Id, p.Name }).ToList();
            var query = _context.CustomerDiscounts.Select(p => new CustomerDiscountViewModel
            {
                Id = p.Id,
                DiscountRate = p.DiscountRate,
                ProductId = p.ProductId,
                StartTime = p.StartTime.ToFarsi(),
                EndTime = p.EndTime.ToFarsi(),
                StartTimeEn = p.StartTime,
                EndTimeEn = p.EndTime,
                Reason = p.Reason,
                IsActive = p.IsActive
            });

            if (searchModel.ProductId > 0)
                query = query.Where(p => p.ProductId == searchModel.ProductId);

            if (!string.IsNullOrWhiteSpace(searchModel.StartTime))
            {
                var startTime = searchModel.StartTime.ToGeorgianDateTime();
                query = query.Where(p => p.StartTimeEn <= startTime);
            }
            if (!string.IsNullOrWhiteSpace(searchModel.EndTime))
            {
                var endTime = searchModel.EndTime.ToGeorgianDateTime();
                query = query.Where(p => p.EndTimeEn >= endTime);
            }

            var discounts = query.OrderByDescending(p => p.Id).ToList();

            discounts.ForEach(d =>
                d.ProductName = products.FirstOrDefault(p => p.Id == d.ProductId)?.Name);

            return discounts;
        }
    }
}
