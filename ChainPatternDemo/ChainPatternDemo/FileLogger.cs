using System;
using System.Collections.Generic;
using System.Text;

namespace ChainPatternDemo
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.Level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
