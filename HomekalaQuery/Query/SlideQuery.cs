using HomekalaQuery.Contracts.Slide;
using ShopManagement.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace HomekalaQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _shopContext;
        public SlideQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _shopContext.Slides.Where(p => !p.IsRemoved).Select(p => new SlideQueryModel
            {
                Picture = p.Picture,
                PictureAlt = p.PictureAlt,
                PictureTitle = p.PictureTitle,
                Heading = p.Heading,
                Title = p.Title,
                Text = p.Text,
                Link = p.Link,
                BtnText = p.BtnText
            }).ToList();
        }
    }
}
