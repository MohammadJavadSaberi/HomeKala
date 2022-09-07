namespace OuroFramework.Application
{
    public interface IAuthHelper
    {
        void Signin(AuthViewModel account);
        void SignOut();
        bool IsAuthentication();
        public string GetCurrentAccountRole { get; }
        public AuthViewModel GetCurrentAccountInfo { get; }
    }
}
