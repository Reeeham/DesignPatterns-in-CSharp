using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo
{
    public class Context
    {
        public State State { get; set; }

        public Context()
        {
            State = null;
        }
    }
}
