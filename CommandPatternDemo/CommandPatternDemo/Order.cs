using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    // A command interface.
    public interface Order
    {
        void execute();
    }
}
