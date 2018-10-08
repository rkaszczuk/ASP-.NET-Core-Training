using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Entities;
using Contracts.Services;

namespace BLL.ProductServices
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public LayerResult<ProductModel> GetProductDetails(int id)
        {
            return productRepository.GetById(id);
        }

        public LayerResult<IEnumerable<ProductModel>> GetProductsList()
        {
            return productRepository.GetAll();
        }
    }
}
