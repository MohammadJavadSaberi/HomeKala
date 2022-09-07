namespace OuroFramework.Application
{
    public class AuthViewModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }

        public AuthViewModel() { }
        public AuthViewModel(int id, int roleId, string fullname, string username, string mobile)
        {
            Id = id;
            RoleId = roleId;
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
        }
    }
}