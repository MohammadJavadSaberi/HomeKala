using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure;
using HomekalaQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        private readonly IProductQuery _productQuery;
        private readonly ICommentApplication _commentApplication;
        public ProductModel(IProductQuery productQuery, ICommentApplication commentApplication)
        {
            _productQuery = productQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id)
        {
            Product = _productQuery.GetDetails(id);
        }
        public RedirectToPageResult OnPost(AddComment command, string productSlug)
        {
            command.Type = CommentType.Product;
            command.ParentId = 0;
            _commentApplication.Add(command);
            return RedirectToPage("./Product", new { Id = productSlug });
        }
    }
}
