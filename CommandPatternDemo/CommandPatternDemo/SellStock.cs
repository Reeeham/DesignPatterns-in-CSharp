using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    public class SellStock : Order
    {
       private Stock abcStock;

       public SellStock(Stock abcStock)
       {
        this.abcStock = abcStock;
       }

      public void execute()
      {
        abcStock.sell();
      }
}
}
