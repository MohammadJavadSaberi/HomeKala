using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using AccountManagement.Application.Contracts.Role;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Role
{
    public class IndexModel : PageModel
    {
        public List<RoleViewModel> Roles { get; set; }

        private readonly IRoleApplication _roleApplication;
        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
            Roles = _roleApplication.GetAll();
        }
        public PartialViewResult OnGetCreate()
        {
            var command = new CreateRole
            {
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateRole command)
        {
            var result = _roleApplication.Create(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetEdit(int id)
        {
            var Account = _roleApplication.GetDetails(id);
            return Partial("./Edit", Account);
        }
        public JsonResult OnPostEdit(EditRole command)
        {
            var result = _roleApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
