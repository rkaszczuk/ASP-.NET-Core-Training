using Contracts.Entities;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DAL
{
    public class OrderRepository : Repository<OrderModel>, IOrderRepository
    {
        public OrderRepository()
        {
            Table = new List<OrderModel>();
        }
        public LayerResult<OrderModel> MakeOrder(OrderModel order)
        {
            order.Id = Table.Max(x => x.Id);
            Table.Add(order);
            return new LayerResult<OrderModel>(order);
        }
    }
}
