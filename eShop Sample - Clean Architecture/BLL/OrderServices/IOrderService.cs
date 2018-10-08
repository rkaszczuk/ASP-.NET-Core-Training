using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.OrderServices
{
    public interface IOrderService
    {
        LayerResult<OrderModel> MakeOrder(int userId, int productId, int qty);
    }
}
