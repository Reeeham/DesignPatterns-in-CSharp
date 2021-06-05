using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class RedCircle : DrawAPI
    {
        //Concrete bridge implementer classes implementing the DrawAPI interface.
        public string drawCircle(int radius, int x, int y)
        {
            return "Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", " + y + "]";
        }
    }
}
