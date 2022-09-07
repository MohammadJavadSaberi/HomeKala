using CommentManagement.Infrastructure;
using DiscountManagement.Infrastructure.EfCore;
using HomekalaQuery.Contracts.Product;
using Microsoft.EntityFrameworkCore;
using OuroFramework.Application;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomekalaQuery.Query
{
    public class ProductQuery : IProductQuery
    {
        private readonly ShopContext _shopContext;
        private readonly DiscountContext _discountContext;
        private readonly CommentContext _commentContext;
        public ProductQuery(ShopContext shopContext, DiscountContext discountContext, CommentContext commentContext)
        {
            _shopContext = shopContext;
            _discountContext = discountContext;
            _commentContext = commentContext;
        }

        public ProductQueryModel GetDetails(string slug)
        {
            var productsPrice = _shopContext.Products.Select(x => new { x.UnitPrice, x.Id }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now)
                .Select(p => new { p.DiscountRate, p.ProductId, p.EndTime }).ToList();
            var product = _shopContext.Products.Select(p => new ProductQueryModel
            {
                Id = p.Id,
                Name = p.Name,
                ShortDescription = p.ShortDescription,
                Description = p.Description,
                UnitPrice = p.UnitPrice.ToMoney(),
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Slug = p.Slug,
                Category = p.Category.Name,
                CategorySlug = p.Category.Slug,
                IsInStock = p.IsInStock,
                Pictures = MapProductPictures(p.ProductPictures),
            }).FirstOrDefault(p => p.Slug == slug);
            var unitPrice = productsPrice.FirstOrDefault(p => p.Id == product.Id).UnitPrice;
            var discount = discounts.FirstOrDefault(p => p.ProductId == product.Id);
            if (discount != null)
            {
                var discountRate = discount.DiscountRate;
                product.DiscountRate = discountRate;
                var finalPrice = Math.Round((unitPrice * discountRate) / 100);
                product.HasDiscount = discountRate > 0;
                product.UnitPriceWithDiscount = (unitPrice - finalPrice).ToMoney();
                product.DiscountEndDate = discount.EndTime.ToDiscountFormat();
            }
            product.Comments = _commentContext.Comments
                .Where(p => p.IsConfirmed)
                .Where(p => p.Type == CommentType.Product)
                .Where(p => p.OwnerRecordId == product.Id)
                .Select(p => new CommentQueryModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Message = p.Message
                }).OrderByDescending(p => p.Id).ToList();

            return product;
        }

        private static List<ProductPictureQueryModel> MapProductPictures(List<ProductPicture> productPictures)
        {
            return productPictures.Select(p => new ProductPictureQueryModel
            {
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                IsRemoved = p.IsRemoved
            }).Where(p => !p.IsRemoved).ToList();
        }

        public List<ProductQueryModel> GetLatestProduct()
        {
            var productsPrice = _shopContext.Products.Select(x => new { x.UnitPrice, x.Id }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now)
                .Select(p => new { p.DiscountRate, p.ProductId }).ToList();
            var products = _shopContext.Products.Select(p => new ProductQueryModel
            {
                Id = p.Id,
                Name = p.Name,
                UnitPrice = p.UnitPrice.ToMoney(),
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Slug = p.Slug,
                Category = p.Category.Name
            }).OrderByDescending(p => p.Id).Take(6).ToList();

            foreach (var product in products)
            {
                var unitPrice = productsPrice.FirstOrDefault(p => p.Id == product.Id).UnitPrice;
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
            return products;
        }

        public List<ProductQueryModel> Search(string value)
        {
            var productsPrice = _shopContext.Products.Select(x => new { x.UnitPrice, x.Id }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now)
                .Select(p => new { p.DiscountRate, p.ProductId }).ToList();
            var query = _shopContext.Products.Select(p => new ProductQueryModel
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
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(p => p.Name.Contains(value) || p.Category.Contains(value));

            var products = query.OrderByDescending(p => p.Id).ToList();

            foreach (var product in products)
            {
                var unitPrice = productsPrice.FirstOrDefault(p => p.Id == product.Id).UnitPrice;
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
            return products;
        }
    }
}
