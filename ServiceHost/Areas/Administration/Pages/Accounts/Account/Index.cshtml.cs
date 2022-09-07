using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Account
{
    public class IndexModel : PageModel
    {
        public AccountSearchModel SearchModel { get; set; }
        public List<AccountViewModel> Accounts { get; set; }
        public List<RoleViewModel> Roles { get; set; }

        private readonly IAccountApplication _accountApplication;
        private readonly IRoleApplication _roleApplication;
        public IndexModel(IAccountApplication accountApplication, IRoleApplication roleApplication)
        {
            _accountApplication = accountApplication;
            _roleApplication = roleApplication;
        }

        public void OnGet(AccountSearchModel searchModel)
        {
            Accounts = _accountApplication.Search(searchModel);
            Roles = _roleApplication.GetAll();
        }
        public PartialViewResult OnGetCreate()
        {
            var command = new CreateAccount
            {
                Roles = _roleApplication.GetAll()
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateAccount command)
        {
            var result = _accountApplication.Create(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetEdit(int id)
        {
            var Account = _accountApplication.GetDetails(id);
            Account.Roles = _roleApplication.GetAll();
            return Partial("./Edit", Account);
        }
        public JsonResult OnPostEdit(EditAccount command)
        {
            var result = _accountApplication.Edit(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetChangePassword(int id)
        {
            var command = new ChangePassword { Id = id };
            return Partial("./ChangePassword", command);
        }
        public JsonResult OnPostChangePassword(ChangePassword command)
        {
            var result = _accountApplication.ChangePassword(command);
            return new JsonResult(result);
        }
    }
}
