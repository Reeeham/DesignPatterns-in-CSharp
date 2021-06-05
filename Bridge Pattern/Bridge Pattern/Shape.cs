using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    //An abstract class Shape using the DrawAPI interface
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        protected Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract string draw();


    }
}
