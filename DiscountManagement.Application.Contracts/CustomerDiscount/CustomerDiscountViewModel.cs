using System;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public class CustomerDiscountViewModel
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public DateTime StartTimeEn { get; set; }
        public DateTime EndTimeEn { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
    }
}
