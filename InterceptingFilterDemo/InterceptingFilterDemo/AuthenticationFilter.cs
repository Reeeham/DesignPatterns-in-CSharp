using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class AuthenticationFilter : Filter
    {
        public void execute(string Request)
        {
            Console.WriteLine("Authenticating request: " + Request);
        }


    }
}
