using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IProductRepository : IRepository<ProductModel>
    {
    }
}
