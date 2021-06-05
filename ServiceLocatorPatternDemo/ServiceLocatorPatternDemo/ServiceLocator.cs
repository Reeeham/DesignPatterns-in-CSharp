using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    public class ServiceLocator
    {
        private static Cache cache;

        static ServiceLocator()
        {
            cache = new Cache();
        }

        public static Service GetService(string jndiName)
        {
            Service service = cache.GetService(jndiName);
            if(service != null)
            {
                return service;
            }
            InitialContext context = new InitialContext();
            Service service1 = (Service)context.Lookup(jndiName);
            cache.AddService(service1);
            return service1;
        }
    }
}
    

