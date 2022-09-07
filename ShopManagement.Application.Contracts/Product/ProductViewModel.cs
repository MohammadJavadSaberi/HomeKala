﻿namespace ShopManagement.Application.Contracts.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double UnitPrice { get; set; }
        public bool IsInStock { get; set; }
        public string Picture { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
    }
}
