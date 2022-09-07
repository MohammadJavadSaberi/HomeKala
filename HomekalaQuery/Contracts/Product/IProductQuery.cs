using System.Collections.Generic;

namespace HomekalaQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetDetails(string slug);
        List<ProductQueryModel> GetLatestProduct();
        List<ProductQueryModel> Search(string value);
    }
}
