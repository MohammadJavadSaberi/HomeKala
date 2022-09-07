using System.Collections.Generic;
using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Application.Contracts.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Discounts.ColleagueDiscount
{
    public class IndexModel : PageModel
    {
        public ColleagueDiscountSearchModel SearchModel { get; set; }
        public List<ColleagueDiscountViewModel> ColleagueDiscounts { get; set; }
        public List<ProductViewModel> Products { get; set; }

        private readonly IProductApplication _productApplication;
        private readonly IColleagueDiscountApplication _colleagueDiscountApplication;
        public IndexModel(IProductApplication productApplication, IColleagueDiscountApplication colleagueDiscountApplication)
        {
            _productApplication = productApplication;
            _colleagueDiscountApplication = colleagueDiscountApplication;
        }

        public void OnGet(ColleagueDiscountSearchModel searchModel)
        {
            ColleagueDiscounts = _colleagueDiscountApplication.Search(searchModel);
            Products = _productApplication.GetProducts();
        }
        public PartialViewResult OnGetCreate()
        {
            var command = new CreateColleagueDiscount
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Create(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetEdit(int id)
        {
            var colleagueDiscount = _colleagueDiscountApplication.GetDetails(id);
            colleagueDiscount.Products = _productApplication.GetProducts();
            return Partial("./Edit", colleagueDiscount);
        }
        public JsonResult OnPostEdit(EditColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Edit(command);
            return new JsonResult(result);
        }
        public RedirectToPageResult OnGetDeActive(int id)
        {
            _colleagueDiscountApplication.DeActive(id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnGetIsActive(int id)
        {
            _colleagueDiscountApplication.Active(id);
            return RedirectToPage("./Index");
        }
    }
}
