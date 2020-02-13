using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKBakery.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingcart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingcart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlace = DateTime.Now;
            _appDbContext.Orders.Add(order);
            var shoppingCartItems = _shoppingcart.ShoppingCartItems;
            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Pie.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
