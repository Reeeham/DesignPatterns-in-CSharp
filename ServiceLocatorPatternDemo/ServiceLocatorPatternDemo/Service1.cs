using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    public class Service1 : Service
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string GetName()
        {
            return "Service1";

        }
    }
}
