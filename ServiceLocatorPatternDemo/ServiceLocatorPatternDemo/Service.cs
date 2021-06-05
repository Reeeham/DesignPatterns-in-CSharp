using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorPatternDemo
{
    public interface Service
    {
        public string GetName();
        public void Execute();
    }
}
