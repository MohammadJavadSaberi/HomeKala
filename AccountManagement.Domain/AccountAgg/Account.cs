using AccountManagement.Domain.RoleAgg;
using OuroFramework.Domain;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase<int>
    {
        public string FullName { get; private set; }
        public string UserName { get; private set; }
        public string PassWord { get; private set; }
        public string Mobile { get; private set; }
        public string ProfilePicture { get; private set; }
        public int RoleId { get; private set; }
        public Role Role { get; private set; }

        public Account(string fullName, string userName, string passWord, string mobile, string profilePicture, int roleId)
        {
            FullName = fullName;
            UserName = userName;
            PassWord = passWord;
            Mobile = mobile;
            ProfilePicture = profilePicture;
            RoleId = roleId;
            if (RoleId == 0)
                RoleId = 2;
        }

        public void Edit(string fullName, string userName, string mobile, string profilePicture, int roleId)
        {
            FullName = fullName;
            UserName = userName;
            Mobile = mobile;
            if (!string.IsNullOrWhiteSpace(profilePicture))
                ProfilePicture = profilePicture;

            RoleId = roleId;
        }
        public void ChangePassword(string password)
        {
            PassWord = password;
        }
    }
}
