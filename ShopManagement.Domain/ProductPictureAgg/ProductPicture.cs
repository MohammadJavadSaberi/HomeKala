﻿using OuroFramework.Domain;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Domain.ProductPictureAgg
{
    public class ProductPicture : EntityBase<int>
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsRemoved { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        protected ProductPicture() { }
        public ProductPicture(string picture, string pictureAlt, string pictureTitle, int productId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ProductId = productId;
            IsRemoved = false;
        }
        public void Edit(string picture, string pictureAlt, string pictureTitle, int productId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ProductId = productId;
        }
        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
