﻿using System.Collections.Generic;

namespace HomekalaQuery.Contracts.Product
{
    public class ProductQueryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string UnitPriceWithDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string Category { get; set; }
        public string CategorySlug { get; set; }
        public bool HasDiscount { get; set; }
        public bool IsInStock { get; set; }
        public string DiscountEndDate { get; set; }
        public List<ProductPictureQueryModel> Pictures { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
    }
    public class ProductPictureQueryModel
    {
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public bool IsRemoved { get; set; }
    }
    public class CommentQueryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
