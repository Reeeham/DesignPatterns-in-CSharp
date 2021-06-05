using System;
using System.Collections.Generic;
using System.Text;

namespace ChainPatternDemo
{
    public abstract class AbstractLogger
    {
      
        public static int INFO { get; set; } = 1;
        public static int DEBUG { get; set; } = 2;
        public static int ERROR { get; set; } = 3;
        protected int Level { get; set; }
        //next element in chain or responsibility
        public AbstractLogger nextLogger { get; set; }

        public void LogMessage(int level, string message)
        {
            if(Level <= level)
            {
                Write(message);
            }
            if(nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }
        abstract protected void Write(string message);

    }
}
