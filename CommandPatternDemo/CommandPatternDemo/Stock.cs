using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    //A a request class.
    public class Stock
    {
        private string Name = "ABC";
        private int Quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] sold");
        }
    }
}
