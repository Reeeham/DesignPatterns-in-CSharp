using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
