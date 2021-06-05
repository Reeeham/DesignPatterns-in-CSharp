using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class Target
    {
        public void execute(string Request)
        {
            Console.WriteLine("Executing request: " + Request);
        }
    }
}
