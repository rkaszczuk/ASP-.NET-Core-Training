using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Entities;
using Contracts.Services;

namespace BLL.OrderServices
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;
        private IUserRepository userRepository;
        private IProductRepository productRepository;
        public OrderService(IOrderRepository orderRepository, IUserRepository userRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.userRepository = userRepository;
            this.productRepository = productRepository;
        }
        public LayerResult<OrderModel> MakeOrder(int userId, int productId, int qty)
        {
            OrderModel order = new OrderModel();
            order.Product = productRepository.GetById(productId).Result;
            order.User = userRepository.GetById(userId).Result;
            var result = orderRepository.MakeOrder(order);
            return result;
        }
    }
}
