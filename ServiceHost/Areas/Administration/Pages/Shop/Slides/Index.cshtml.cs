using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Slide;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slides
{
    public class IndexModel : PageModel
    {
        public List<SlideViewModel> Slides { get; set; }

        private readonly ISlideApplication _slideApplication;
        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }

        public void OnGet()
        {
            Slides = _slideApplication.GetSlides();
        }
        public PartialViewResult OnGetCreate()
        {
            var command = new CreateSlide();
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateSlide command)
        {
            var result = _slideApplication.Create(command);
            return new JsonResult(result);
        }
        public PartialViewResult OnGetEdit(int id)
        {
            var slide = _slideApplication.GetDetails(id);
            return Partial("./Edit", slide);
        }
        public JsonResult OnPostEdit(EditSlide command)
        {
            var result = _slideApplication.Edit(command);
            return new JsonResult(result);
        }
        public RedirectToPageResult OnGetRemove(int id)
        {
            _slideApplication.Remove(id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnGetRestore(int id)
        {
            _slideApplication.Restore(id);
            return RedirectToPage("./Index");
        }
    }
}
