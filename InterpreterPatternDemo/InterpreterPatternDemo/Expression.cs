using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPatternDemo
{
    public interface Expression
    {
        //Create an expression interface.
        public bool interpret(string context);
    }
}
