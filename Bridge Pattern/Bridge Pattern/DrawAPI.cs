using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{

    //this is a bridge implementer interface
    public interface DrawAPI
    {
        public string drawCircle(int radius,int x, int y);
    }
}
