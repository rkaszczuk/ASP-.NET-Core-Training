using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ProductServices
{
    public interface IProductService
    {
        LayerResult<IEnumerable<ProductModel>> GetProductsList();
        LayerResult<ProductModel> GetProductDetails(int id);
    }
}
