using OuroFramework.Domain;
using ShopManagement.Application.Contracts.ProductPicture;
using System.Collections.Generic;

namespace ShopManagement.Domain.ProductPictureAgg
{
    public interface IProductPictureRepository : IRepositoryBase<int, ProductPicture>
    {
        EditProductPicture GetDetails(int id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}
