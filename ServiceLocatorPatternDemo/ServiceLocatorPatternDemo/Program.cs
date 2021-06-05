using System;

namespace ServiceLocatorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();
            service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();

            Console.ReadLine();
        }
    }
}
