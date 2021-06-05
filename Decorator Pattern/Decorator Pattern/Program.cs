using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Circle = new Circle();
            Shape RedCircle = new RedShapeDecorator(new Circle());
            Shape RedRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            Circle.Draw();
            Console.WriteLine("Circle of red border");
            RedCircle.Draw();
            Console.WriteLine("Rectangle of red border");
            RedRectangle.Draw();
            Console.ReadLine();
        }
    }
}
