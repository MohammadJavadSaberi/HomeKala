using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;
using OuroFramework.Application;
using OuroFramework.Infrastructure;
using ShopManagement.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace DiscountManagement.Infrastructure.EfCore.Repositories
{
    public class ColleagueDiscountRepository : RepositoryBase<int, ColleagueDiscount>, IColleagueDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;
        public ColleagueDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditColleagueDiscount GetDetails(int id)
        {
            return _context.ColleagueDiscounts.Select(p => new EditColleagueDiscount
            {
                Id = p.Id,
                ProductId = p.ProductId,
                DiscountRate = p.DiscountRate
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel)
        {
            var products = _shopContext.Products.Select(p => new { p.Id, p.Name }).ToList();
            var query = _context.ColleagueDiscounts.Select(p => new ColleagueDiscountViewModel
            {
                Id = p.Id,
                DiscountRate = p.DiscountRate,
                ProductId = p.ProductId,
                IsActive = p.IsActive,
                CreationTime = p.CreationTime.ToFarsi()
            });

            if (searchModel.ProductId > 0)
                query = query.Where(p => p.ProductId == searchModel.ProductId);

            var discounts = query.OrderByDescending(p => p.DiscountRate).ToList();
            discounts.ForEach(d =>
                d.ProductName = products.FirstOrDefault(p => p.Id == d.ProductId)?.Name);

            return discounts;
        }
    }
}
