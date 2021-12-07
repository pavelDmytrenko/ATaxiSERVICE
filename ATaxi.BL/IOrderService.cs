using ATaxi.DL;
using System.Collections.Generic;

namespace ATaxi.BL
{ 
    public interface IOrderService
    {
        Order GetOrder(int? id);
        List<Order> GetOrders();
        void AddOrder(Order order);
        Order DelOrder(int id);

    }
}
