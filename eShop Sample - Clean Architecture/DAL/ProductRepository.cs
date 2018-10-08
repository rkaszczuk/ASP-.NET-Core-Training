using Contracts.Entities;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ProductRepository : Repository<ProductModel>, IProductRepository
    {
        public ProductRepository()
        {
            Table = new List<ProductModel>()
            {
                new ProductModel(){ Id = 1, Name = "Felga stalowa 15'", Price = 150},
                new ProductModel(){ Id = 2, Name = "Płyn chłodniczy 5l", Price = 15},
                new ProductModel(){ Id = 3, Name = "Klocki hamulcowe", Price = 180}
            };
        }
    }
}
