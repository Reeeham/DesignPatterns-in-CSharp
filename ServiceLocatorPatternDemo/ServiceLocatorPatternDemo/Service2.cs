using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    public class Service2 : Service
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service2");
        }

        public string GetName()
        {
            return "Service2";
        }
    }
}
