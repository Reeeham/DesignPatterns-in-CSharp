using System;
using System.Collections.Generic;
using System.Text;

namespace NullPatternDemo
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(String Name)
        {
            this.Name = Name;
        }
        public override string getName()
        {
            return Name;
        }

        public override bool isNil()
        {
            return false;
        }
    }
}
