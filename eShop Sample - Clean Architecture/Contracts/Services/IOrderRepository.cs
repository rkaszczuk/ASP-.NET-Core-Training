using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IOrderRepository : IRepository<OrderModel>
    {
        LayerResult<OrderModel> MakeOrder(OrderModel order);
    }
}
