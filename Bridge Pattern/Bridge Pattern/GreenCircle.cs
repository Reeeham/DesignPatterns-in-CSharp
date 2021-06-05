using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class GreenCircle : DrawAPI
    {

        //Concrete bridge implementer classes implementing the DrawAPI interface.
        public string drawCircle(int radius, int x, int y)
        {
            return "Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]";
        }
    }
}
