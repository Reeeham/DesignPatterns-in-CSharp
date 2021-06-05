using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class DebugFilter : Filter
    {
        public void execute(string Request)
        {
            Console.WriteLine("request log: " + Request);
        }

    }
}
