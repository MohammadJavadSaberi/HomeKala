using HomekalaQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public List<ProductQueryModel> Products;
        private readonly IProductQuery _productQuery;
        public SearchModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public void OnGet(string value)
        {
            TempData["Value"] = value;
            Products = _productQuery.Search(value);
        }
    }
}
