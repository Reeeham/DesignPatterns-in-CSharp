using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPatternDemo
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, Shape> CircleMap = new Dictionary<string, Shape>();

        public static Shape getCircle(string color)
        {
            // Get value that exists.
            Circle circle;
            if (CircleMap.ContainsKey(color))
            {
                return circle = (Circle)CircleMap[color];
            }
            else
            {
                circle = new Circle(color);
                CircleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            
            return circle;
        }
    }
}
