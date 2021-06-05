using System;

namespace TemplatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();
            Console.WriteLine();
            game = new Football();
            game.play();
            Console.ReadLine();

        }
    }
}
