using System;
using System.Collections.Generic;
using System.Text;

namespace NullPatternDemo
{
    public abstract class AbstractCustomer
    {
        protected string Name;
        public abstract bool isNil();
        public abstract string getName();
    }
}
