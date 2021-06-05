using System;
using System.Collections.Generic;
using System.Text;

namespace ChainPatternDemo
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.Level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}
