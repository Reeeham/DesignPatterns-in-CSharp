using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 20, new GreenCircle());

            Console.WriteLine(redCircle.draw());
            Console.WriteLine(greenCircle.draw());
        }
    }
}
