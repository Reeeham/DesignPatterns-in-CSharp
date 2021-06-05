using System;

namespace MediatorPatternDemo
{
    class Program
    {
        //Use the User object to show communications between them
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");

            Console.ReadLine();
        }
    }
}
