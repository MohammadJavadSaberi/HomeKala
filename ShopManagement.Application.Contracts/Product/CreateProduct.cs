using Microsoft.AspNetCore.Http;
using OuroFramework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Code { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public double UnitPrice { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Description { get; set; }

        [AllowedFileTypes(new string[] { ".png", ".jpg" }, ErrorMessage = ValidationMessages.FileFormatInvalid)]
        [MaxFileSize(2 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Slug { get; set; }

        [Range(1, 1000, ErrorMessage = ValidationMessages.Required)]
        public int ProductCategoryId { get; set; } 
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}
