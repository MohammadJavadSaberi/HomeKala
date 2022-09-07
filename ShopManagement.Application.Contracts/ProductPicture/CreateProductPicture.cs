using Microsoft.AspNetCore.Http;
using OuroFramework.Application;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [AllowedFileTypes(new string[] { ".png", ".jpg" }, ErrorMessage = ValidationMessages.FileFormatInvalid)]
        [MaxFileSize(2 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string PictureTitle { get; set; }
        [Range(1, 1000, ErrorMessage = ValidationMessages.Required)]
        public int ProductId { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
