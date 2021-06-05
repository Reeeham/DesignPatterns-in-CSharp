using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo
{
    public class Computer : ComputerPart
    {
        ComputerPart[] parts;
        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}
