using System;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public class CustomerDiscountSearchModel
    {
        public int ProductId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
