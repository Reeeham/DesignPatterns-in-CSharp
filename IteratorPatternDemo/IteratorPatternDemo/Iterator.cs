using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternDemo
{
    public interface Iterator
    {
        public bool hasNext();
        public object next();
    }
}
