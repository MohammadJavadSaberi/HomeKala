namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public class ColleagueDiscountViewModel
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CreationTime { get; set; }
        public bool IsActive { get; set; }
    }
}
