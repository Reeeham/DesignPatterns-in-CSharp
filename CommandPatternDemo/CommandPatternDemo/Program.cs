using System;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Broker class to take and execute commands.
            Stock abcStock = new Stock();
            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
            Console.ReadLine();
        }
    }
}
