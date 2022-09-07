using OuroFramework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using System.Collections.Generic;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly IFileUploader _uploader;
        public ProductApplication(IProductRepository productRepository, IFileUploader uploader)
        {
            _productRepository = productRepository;
            _uploader = uploader;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();

            if (_productRepository.Exists(p => p.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var path = $"{_productRepository.GetProductCategorySlugBy(command.ProductCategoryId)}/{slug}";
            var product = new Product(command.Name, command.Code, command.UnitPrice, command.ShortDescription, command.Description, _uploader.Upload(command.Picture, path), command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug, command.ProductCategoryId);

            _productRepository.Create(product);
            return operation.Succedded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(p => p.Name == command.Name && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var product = _productRepository.GetProductWithCategorySlugBy(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            var slug = command.Slug.Slugify();
            var path = $"{product.Category.Slug}/{slug}";
            product.Edit(command.Name, command.Code, command.UnitPrice, command.ShortDescription, command.Description, _uploader.Upload(command.Picture, path), command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug, command.ProductCategoryId);
            _productRepository.Save();
            return operation.Succedded();
        }

        public EditProduct GetDetails(int id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public OperationResult InStock(int id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            product.InStock();
            _productRepository.Save();
            return operation.Succedded();
        }

        public OperationResult NotInStock(int id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            product.NotInStock();
            _productRepository.Save();
            return operation.Succedded();
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }
    }
}
