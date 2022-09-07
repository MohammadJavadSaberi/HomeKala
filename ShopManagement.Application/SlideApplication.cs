using OuroFramework.Application;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;
using System.Collections.Generic;

namespace ShopManagement.Application
{
    public class SlideApplication : ISlideApplication
    {
        private readonly ISlideRepository _slideRepository;
        public SlideApplication(ISlideRepository slideRepository)
        {
            _slideRepository = slideRepository;
        }

        public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();
            var slide = new Slide(command.Picture, command.PictureAlt, command.PictureTitle,
                command.Heading, command.Title,
                command.Title, command.Link, command.BtnText);
            _slideRepository.Create(slide);
            _slideRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(command.Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            slide.Edit(command.Picture, command.PictureAlt, command.PictureTitle,
                command.Heading, command.Title,
                command.Title, command.Link, command.BtnText);
            _slideRepository.Save();
            return operation.Succedded();
        }

        public EditSlide GetDetails(int id)
        {
            return _slideRepository.GetDetails(id);
        }

        public List<SlideViewModel> GetSlides()
        {
            return _slideRepository.GetSlides();
        }

        public OperationResult Remove(int id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            slide.Remove();
            _slideRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Restore(int id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            slide.Restore();
            _slideRepository.Save();
            return operation.Succedded();
        }
    }
}
