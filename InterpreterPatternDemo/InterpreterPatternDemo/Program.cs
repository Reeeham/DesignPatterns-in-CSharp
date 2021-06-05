using System;

namespace InterpreterPatternDemo
{
    class Program
    {
        // InterpreterPatternDemo uses Expression class to create rules and then parse them
        static void Main(string[] args)
        {
            Expression isMale = getMaleExpression();
            Expression isMarriedWoman = getMarriedWomanExpression();
            Console.WriteLine("John is male? " + isMale.interpret("John"));
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.interpret("Married Julie"));
            Console.ReadLine();
        }
        //Rule: Robert and John are male
        public static Expression getMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }
        //Rule: Julie is a married women
        public static Expression getMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
    }
}
