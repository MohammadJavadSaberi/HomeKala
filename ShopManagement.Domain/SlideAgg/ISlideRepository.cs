using OuroFramework.Domain;
using ShopManagement.Application.Contracts.Slide;
using System.Collections.Generic;

namespace ShopManagement.Domain.SlideAgg
{
    public interface ISlideRepository : IRepositoryBase<int, Slide>
    {
        EditSlide GetDetails(int id);
        List<SlideViewModel> GetSlides();
    }
}
