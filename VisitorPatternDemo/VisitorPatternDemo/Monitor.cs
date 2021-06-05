using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo
{
    public class Monitor : ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
