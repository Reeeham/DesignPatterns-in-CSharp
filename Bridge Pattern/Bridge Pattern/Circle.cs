using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class Circle : Shape
    {
        protected int x, y, radius;
       
        public  Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
                  
        }
        public override string draw()
        {
            return drawAPI.drawCircle(x, y, radius);
        }
    }
}
