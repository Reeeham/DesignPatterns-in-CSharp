using System;

namespace FrontControllerPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.dispatchRequest("HOME");
            frontController.dispatchRequest("STUDENT");

            Console.ReadLine();
        }
    }
}
