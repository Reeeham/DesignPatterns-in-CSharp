using System;
using System.Collections.Generic;
using System.Text;

namespace NullPatternDemo
{
    public class NullCustomer : AbstractCustomer
    {
        public override string getName()
        {
            return "Not Available in Customer Database";
        }

        public override bool isNil()
        {
            return true;
        }
    }
}
