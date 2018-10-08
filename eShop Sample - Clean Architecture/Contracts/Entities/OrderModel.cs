using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class OrderModel : IEntity
    {
        public UserModel User { get; set; }
        public ProductModel Product { get; set; }
        public int Qty { get; set; }
        public int Id { get; set; }
    }
}
