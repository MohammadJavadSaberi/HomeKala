using Microsoft.AspNetCore.Mvc;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryApplication _productCategory;
        public MenuViewComponent(IProductCategoryApplication productCategory)
        {
            _productCategory = productCategory;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
