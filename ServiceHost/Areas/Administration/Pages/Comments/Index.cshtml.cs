using System.Collections.Generic;
using CommentManagement.Application.Contracts.Comment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Comments
{
    [Authorize(Roles = "1, 4")]
    public class IndexModel : PageModel
    {
        public CommentSearchModel SearchModel { get; set; }
        public List<CommentViewModel> Comments { get; set; }

        private readonly ICommentApplication _commentApplication;
        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
        }

        public RedirectToPageResult OnGetConfirm(int id)
        {
            _commentApplication.Confirm(id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnGetCancel(int id)
        {
            _commentApplication.Cancel(id);
            return RedirectToPage("./Index");
        }
    }
}
