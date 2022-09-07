using OuroFramework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Collections.Generic;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IFileUploader _uploader;
        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository, IFileUploader uploader)
        {
            _productCategoryRepository = productCategoryRepository;
            _uploader = uploader;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();

            if (_productCategoryRepository.Exists(p => p.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            string slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.Name, command.Description, _uploader.Upload(command.Picture, slug), command.PictureAlt, command.PictureTitle,
                command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);

            if (productCategory == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (_productCategoryRepository.Exists(p => p.Name == command.Name && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            string slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, _uploader.Upload(command.Picture, slug), command.PictureAlt, command.PictureTitle,
                command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.Save();
            return operation.Succedded();
        }

        public EditProductCategory GetDetails(int id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _productCategoryRepository.GetProductCategories();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
