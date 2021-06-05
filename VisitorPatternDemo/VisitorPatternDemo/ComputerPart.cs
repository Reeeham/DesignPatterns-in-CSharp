using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo
{
    public interface ComputerPart
    {
        public void accept(ComputerPartVisitor computerPartVisitor);

    }
}
