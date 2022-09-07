using Microsoft.AspNetCore.Http;
using OuroFramework.Application;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Name { get; set; }

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
    }
}
