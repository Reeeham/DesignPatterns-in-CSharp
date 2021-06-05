using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle:: Draw");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square:: Draw");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square:: Draw");
        }
    }
}
