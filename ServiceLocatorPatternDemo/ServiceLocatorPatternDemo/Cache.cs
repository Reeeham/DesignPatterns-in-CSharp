using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    public class Cache
    {
        private IList Services;

        public Cache()
        {
            Services = new ArrayList();
        }
        public Service GetService(string serviceName)
        {
            foreach(Service service in Services)
            {
                if(service.GetName().Equals(serviceName,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return service;
                }
            }

            return null;
        }

        public void AddService(Service newService)
        {
            bool exists = false;
            foreach(Service service in Services)
            {
                if(service.GetName().Equals(newService.GetName()))
                {
                    exists = true;
                }
            }
            if(!exists)
            {
                Services.Add(newService);
            }
        }
    }
}
