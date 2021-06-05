using System;

namespace ChainPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger LoggerChain = getChainOfLoggers();
            LoggerChain.LogMessage(AbstractLogger.INFO, "This is an information");
            LoggerChain.LogMessage(AbstractLogger.DEBUG, "This is an debug level information.");
            LoggerChain.LogMessage(AbstractLogger.ERROR,"This is an error information.");

            Console.ReadLine();

        }

        //Create different types of loggers.Assign them error levels and set next logger in each logger.
        //Next logger in each logger represents the part of the chain
        static AbstractLogger getChainOfLoggers()
        {

            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);
            errorLogger.nextLogger = fileLogger;
            fileLogger.nextLogger = consoleLogger;
            return errorLogger;
        }
    }
}
