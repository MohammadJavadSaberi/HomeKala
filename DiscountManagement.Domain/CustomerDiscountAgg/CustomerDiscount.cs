using OuroFramework.Domain;
using System;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public class CustomerDiscount : EntityBase<int>
    {
        public int DiscountRate { get; private set; }
        public int ProductId { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public bool IsActive { get; private set; }
        public string Reason { get; private set; }

        public CustomerDiscount(int discountRate, int productId, DateTime startTime, DateTime endTime, string reason)
        {
            DiscountRate = discountRate;
            ProductId = productId;
            StartTime = startTime;
            EndTime = endTime;
            Reason = reason;
            IsActive = true;
        }
        public void Edit(int discountRate, int productId, DateTime startTime, DateTime endTime, string reason)
        {
            DiscountRate = discountRate;
            ProductId = productId;
            StartTime = startTime;
            EndTime = endTime;
            Reason = reason;
        }
        public void Active()
        {
            IsActive = true;
        }
        public void DeActive()
        {
            IsActive = false;
        }
    }
}
