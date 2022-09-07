﻿using OuroFramework.Application;
using OuroFramework.Infrastructure;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Infrastructure.Repositories
{
    public class ProductCategoryRepository :
        RepositoryBase<int, ProductCategory>, IProductCategoryRepository
    {
        private readonly ShopContext _context;
        public ProductCategoryRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProductCategory GetDetails(int id)
        {
            return _context.ProductCategories.Select(p => new EditProductCategory
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                //Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Keywords = p.Keywords,
                MetaDescription = p.MetaDescription,
                Slug = p.Slug
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _context.ProductCategories.Select(p => new ProductCategoryViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Picture = p.Picture,
                CreationTime = p.CreationTime.ToFarsi(),
                ProductsCount = 0
            }).ToList();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(p => new ProductCategoryViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Picture = p.Picture,
                CreationTime = p.CreationTime.ToFarsi(),
                ProductsCount = 0
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(p => p.Name.Contains(searchModel.Name));

            return query.OrderByDescending(p => p.Id).ToList();
        }
    }
}
