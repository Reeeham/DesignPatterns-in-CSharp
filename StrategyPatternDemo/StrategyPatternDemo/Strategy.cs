using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    public interface Strategy
    {
        public int DoOperation(int num1, int num2);
    }
}
