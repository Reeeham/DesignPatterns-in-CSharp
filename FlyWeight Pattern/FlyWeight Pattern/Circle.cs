using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPatternDemo
{
    public class Circle : Shape
    {
        public string Color { get; set; }
        public int  X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + Color + ", x : " + X + ", y :" + Y + ", radius :" + Radius);
        }
    }
}
