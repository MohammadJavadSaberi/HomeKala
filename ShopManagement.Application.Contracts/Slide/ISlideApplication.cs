using OuroFramework.Application;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Slide
{
    public interface ISlideApplication
    {
        OperationResult Create(CreateSlide command);
        OperationResult Edit(EditSlide command);
        EditSlide GetDetails(int id);
        OperationResult Remove(int id);
        OperationResult Restore(int id);
        List<SlideViewModel> GetSlides();
    }
}
