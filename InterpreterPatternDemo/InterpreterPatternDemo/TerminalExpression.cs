using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPatternDemo
{
    //Create concrete classes implementing the above interface.
    public class TerminalExpression : Expression
    {
        private string data;
        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;

        }
    }
}
