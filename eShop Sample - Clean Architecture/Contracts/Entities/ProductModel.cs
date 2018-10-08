using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class ProductModel : IEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
    }
}
