using OuroFramework.Application;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public interface IProductPictureApplication
    {
        OperationResult Create(CreateProductPicture command);
        OperationResult Edit(EditProductPicture command);
        EditProductPicture GetDetails(int id);
        OperationResult Remove(int id);
        OperationResult Restore(int id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}
