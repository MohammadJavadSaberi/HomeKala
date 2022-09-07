﻿namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationTime { get; set; }
        public int ProductsCount { get; set; }
    }
}
