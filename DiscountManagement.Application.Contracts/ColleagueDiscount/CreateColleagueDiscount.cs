using OuroFramework.Application;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public class CreateColleagueDiscount
    {
        [Range(1, 99, ErrorMessage = ValidationMessages.Required)]
        public int DiscountRate { get; set; }

        [Range(1, 10000, ErrorMessage = ValidationMessages.Required)]
        public int ProductId { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
