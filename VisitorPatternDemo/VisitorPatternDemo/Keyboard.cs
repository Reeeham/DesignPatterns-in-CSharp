using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo
{
    public class Keyboard : ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
