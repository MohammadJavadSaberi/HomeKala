using DiscountManagement.Infrastructure.EfCore;
using HomekalaQuery.Contracts.Product;
using HomekalaQuery.Contracts.ProductCategory;
using Microsoft.EntityFrameworkCore;
using OuroFramework.Application;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomekalaQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly DiscountContext _discountContext;
        public ProductCategoryQuery(ShopContext shopContext, DiscountContext discountContext)
        {
            _shopContext = shopContext;
            _discountContext = discountContext;
        }

        public List<ProductCategoryQueryModel> GetProductCategories()
        {
            return _shopContext.ProductCategories.Select(p => new ProductCategoryQueryModel
            {
                Id = p.Id,
                Name = p.Name,
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Slug = p.Slug
            }).ToList();
        }

        public List<ProductCategoryQueryModel> GetProductCategoriesWithProducts()
        {
            var products = _shopContext.Products.Select(x => new { x.UnitPrice, x.Id }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now)
                .Select(p => new { p.DiscountRate, p.ProductId }).ToList();

            var categories = _shopContext.ProductCategories.Include(x => x.Products)
                .ThenInclude(x => x.Category)
                .Select(p => new ProductCategoryQueryModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Picture = p.Picture,
                    PictureAlt = p.PictureAlt,
                    PictureTitle = p.PictureTitle,
                    Slug = p.Slug,
                    Products = MapProducts(p.Products)
                }).ToList();

            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    var unitPrice = products.FirstOrDefault(p => p.Id == product.Id).UnitPrice;
                    var discount = discounts.FirstOrDefault(p => p.ProductId == product.Id);
                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        var finalPrice = Math.Round((unitPrice * discountRate) / 100);
                        product.HasDiscount = discountRate > 0;
                        product.UnitPriceWithDiscount = (unitPrice - finalPrice).ToMoney();
                    }
                }
            }

            return categories;
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {
            return products.Select(p => new ProductQueryModel
            {
                Id = p.Id,
                Name = p.Name,
                UnitPrice = p.UnitPrice.ToMoney(),
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Slug = p.Slug,
                Category = p.Category.Name,
                CategorySlug = p.Category.Slug
            }).OrderByDescending(p => p.Id).ToList();
        }

        public ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug)
        {
            var products = _shopContext.Products.Select(x => new { x.UnitPrice, x.Id }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now)
                .Select(p => new { p.DiscountRate, p.ProductId, p.EndTime }).ToList();

            var category = _shopContext.ProductCategories.Include(x => x.Products)
                .ThenInclude(x => x.Category)
                .Select(p => new ProductCategoryQueryModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Keywords = p.Keywords,
                    MetaDescription = p.MetaDescription,
                    Slug = p.Slug,
                    Products = MapProducts(p.Products)
                }).FirstOrDefault(p => p.Slug == slug);

            foreach (var product in category.Products)
            {
                var unitPrice = products.FirstOrDefault(p => p.Id == product.Id).UnitPrice;
                var discount = discounts.FirstOrDefault(p => p.ProductId == product.Id);
                if (discount != null)
                {
                    var discountRate = discount.DiscountRate;
                    product.DiscountRate = discountRate;
                    product.DiscountEndDate = discount.EndTime.ToDiscountFormat();
                    var finalPrice = Math.Round((unitPrice * discountRate) / 100);
                    product.HasDiscount = discountRate > 0;
                    product.UnitPriceWithDiscount = (unitPrice - finalPrice).ToMoney();
                }
            }

            return category;
        }
    }
}
