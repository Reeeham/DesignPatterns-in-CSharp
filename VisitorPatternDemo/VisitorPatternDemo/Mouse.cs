using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo
{
    public class Mouse : ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
