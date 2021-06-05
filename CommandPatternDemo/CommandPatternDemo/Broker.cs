using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    // Command invoker class.
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {

            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
