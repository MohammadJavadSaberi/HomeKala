using System.Collections.Generic;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Discounts.CustomerDiscount
{
    public class IndexModel : PageModel
    {
        public CustomerDiscountSearchModel SearchModel { get; set; }
        public List<CustomerDiscountViewModel> CustomerDiscounts { get; set; }
        public List<ProductViewModel> Products { get; set; }

        private readonly IProductApplication _productApplication;
        private readonly ICustomerDiscountApplication _customerDiscountApplication;
        public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscountApplication)
        {
            _productApplication = productApplication;
            _customerDiscountApplication = customerDiscountApplication;
        }

        public void OnGet(CustomerDiscountSearchModel searchModel)
        {
            CustomerDiscounts = _customerDiscountApplication.Search(searchModel);
            Products = _productApplication.GetProducts();
        }
        public PartialViewResult OnGetCreate()
        {
            var command = new CreateCustomerDiscount
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Create(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetEdit(int id)
        {
            var customerDiscount = _customerDiscountApplication.GetDetails(id);
            customerDiscount.Products = _productApplication.GetProducts();
            return Partial("./Edit", customerDiscount);
        }
        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Edit(command);
            return new JsonResult(result);
        }
        public RedirectToPageResult OnGetDeActive(int id)
        {
            _customerDiscountApplication.DeActive(id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnGetIsActive(int id)
        {
            _customerDiscountApplication.Active(id);
            return RedirectToPage("./Index");
        }
    }
}
