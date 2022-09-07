using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        [TempData]
        public string RegisterMessage { get; set; }

        private readonly IAccountApplication _accountApplication;
        public AccountModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSuccess)
                return RedirectToPage("./Index");

            Message = result.Message;
            return Page();
        }
        public IActionResult OnGetLogout()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }
        public IActionResult OnPostRegister(CreateAccount command)
        {
            var result = _accountApplication.Create(command);
            if (result.IsSuccess)
                return RedirectToPage("./Account");

            RegisterMessage = result.Message;
            return Page();
        }
    }
}
