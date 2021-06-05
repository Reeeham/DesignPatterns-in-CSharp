using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    //Create InitialContext for JNDI lookup
    public class InitialContext
    {
        public object Lookup(string jndiName)
        {

            if (jndiName.Equals("SERVICE1", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if (jndiName.Equals("SERVICE2",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }
}
