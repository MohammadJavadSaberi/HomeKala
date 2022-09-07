namespace AccountManagement.Application.Contracts.Account
{
    public class AccountViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string ProfilePicture { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
