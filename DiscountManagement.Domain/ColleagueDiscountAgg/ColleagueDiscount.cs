using OuroFramework.Domain;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public class ColleagueDiscount : EntityBase<int>
    {
        public int DiscountRate { get; private set; }
        public int ProductId { get; private set; }
        public bool IsActive { get; private set; }

        public ColleagueDiscount(int discountRate, int productId)
        {
            DiscountRate = discountRate;
            ProductId = productId;
            IsActive = true;
        }
        public void Edit(int discountRate, int productId)
        {
            DiscountRate = discountRate;
            ProductId = productId;
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
