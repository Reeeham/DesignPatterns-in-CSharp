using FlyWeightPatternDemo;
using System;

namespace FlyWeight_Pattern
{
    class Program
    {
        private static readonly string[] Colors = { "Red", "Green", "Blue", "White", "Black" };
        private static Random random = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.X = getRandomX();
                circle.Y = getRandomY();
                circle.Radius = 100;
                circle.Draw();
            }
            Console.ReadLine();
        }
        private static string getRandomColor()
        {
            return Colors[(int)(random.NextDouble() * Colors.Length)];
        }
        private static int getRandomX()
        {
            return random.Next(0,100);
        }
        private static int getRandomY()
        {
            return random.Next(0,100);
        }
    }
}
