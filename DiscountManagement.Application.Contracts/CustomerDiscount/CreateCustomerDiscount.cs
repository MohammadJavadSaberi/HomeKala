using OuroFramework.Application;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public class CreateCustomerDiscount
    {
        [Range(1, 99, ErrorMessage = ValidationMessages.Required)]
        public int DiscountRate { get; set; }

        [Range(1, 10000, ErrorMessage = ValidationMessages.Required)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string StartTime { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string EndTime { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string Reason { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
