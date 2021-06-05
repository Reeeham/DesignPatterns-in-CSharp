using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    //concrete class implementing the Order interface.
    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.buy();
        }
    }
}
