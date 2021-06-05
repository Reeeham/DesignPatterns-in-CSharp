using System;

namespace VisitorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());


        }
    }
}
