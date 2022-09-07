using Microsoft.EntityFrameworkCore;
using OuroFramework.Infrastructure;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<int, Product>, IProductRepository
    {
        private readonly ShopContext _context;
        public ProductRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProduct GetDetails(int id)
        {
            return _context.Products.Select(p => new EditProduct
            {
                Id = p.Id,
                Name = p.Name,
                Code = p.Code,
                UnitPrice = p.UnitPrice,
                ShortDescription = p.ShortDescription,
                Description = p.Description,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Keywords = p.Keywords,
                MetaDescription = p.MetaDescription,
                Slug = p.Slug,
                ProductCategoryId = p.ProductCategoryId
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _context.Products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();
        }

        public string GetProductCategorySlugBy(int id)
        {
            return _context.Products
                .Include(p => p.Category)
                .Select(p => new { p.Id, p.Category.Slug }).FirstOrDefault(p => p.Id == id).Slug;
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            var query = _context.Products.Include(p => p.Category).Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Code = p.Code,
                UnitPrice = p.UnitPrice,
                IsInStock = p.IsInStock,
                Picture = p.Picture,
                Category = p.Category.Name,
                CategoryId = p.Category.Id
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(p => p.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Code))
                query = query.Where(p => p.Code.Contains(searchModel.Code));

            if (searchModel.ProductCategoryId != 0)
                query = query.Where(p => p.CategoryId == searchModel.ProductCategoryId);

            return query.OrderByDescending(p => p.Id).ToList();
        }

        public Product GetProductWithCategorySlugBy(int id)
        {
            return _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }
    }
}
