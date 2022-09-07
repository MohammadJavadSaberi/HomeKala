using OuroFramework.Application;
using OuroFramework.Infrastructure;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Infrastructure.Repositories
{
    public class SlideRepository : RepositoryBase<int, Slide>, ISlideRepository
    {
        private readonly ShopContext _context;
        public SlideRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditSlide GetDetails(int id)
        {
            return _context.Slides.Select(p => new EditSlide
            {
                Id = p.Id,
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Heading = p.Heading,
                Title = p.Title,
                Text = p.Text,
                Link = p.Link,
                BtnText = p.BtnText
            }).FirstOrDefault(p => p.Id == id);
        }

        public List<SlideViewModel> GetSlides()
        {
            return _context.Slides.Select(p => new SlideViewModel
            {
                Id = p.Id,
                Picture = p.Picture,
                Heading = p.Heading,
                Title = p.Title,
                CreationTime = p.CreationTime.ToFarsi(),
                IsRemoved = p.IsRemoved
            }).OrderByDescending(p => p.Heading).ToList();
        }
    }
}
