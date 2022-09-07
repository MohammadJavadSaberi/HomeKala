using OuroFramework.Application;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductPictureAgg;
using System.Collections.Generic;

namespace ShopManagement.Application
{
    public class ProductPictureApplication : IProductPictureApplication
    {
        private readonly IProductPictureRepository _productPictureRepository;
        private readonly IProductRepository _productRepository;
        private readonly IFileUploader _uploader;
        public ProductPictureApplication(IProductPictureRepository productPictureRepository, IFileUploader uploader, IProductRepository productRepository)
        {
            _productPictureRepository = productPictureRepository;
            _uploader = uploader;
            _productRepository = productRepository;
        }

        public OperationResult Create(CreateProductPicture command)
        {
            var operation = new OperationResult();

            var product = _productRepository.GetProductWithCategorySlugBy(command.ProductId);
            var path = $"{product.Category.Slug}/{product.Slug}";
            var productPicture = new ProductPicture(_uploader.Upload(command.Picture, path), command.PictureAlt, command.PictureTitle, command.ProductId);

            _productPictureRepository.Create(productPicture);
            _productPictureRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(command.Id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);


            var product = _productRepository.GetProductWithCategorySlugBy(command.ProductId);
            var path = $"{product.Category.Slug}/{product.Slug}";
            productPicture.Edit(_uploader.Upload(command.Picture, path), command.PictureAlt, command.PictureTitle, command.ProductId);
            _productPictureRepository.Save();
            return operation.Succedded();
        }

        public EditProductPicture GetDetails(int id)
        {
            return _productPictureRepository.GetDetails(id);
        }

        public OperationResult Remove(int id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            productPicture.Remove();
            _productPictureRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Restore(int id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            productPicture.Restore();
            _productPictureRepository.Save();
            return operation.Succedded();
        }

        public List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel)
        {
            return _productPictureRepository.Search(searchModel);
        }
    }
}
