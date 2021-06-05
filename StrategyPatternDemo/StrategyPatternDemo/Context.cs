using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    public class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public int executeStrategy(int num1, int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }
}
