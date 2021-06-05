using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo
{
    public interface State
    {
        public void DoAction(Context context);
    }
}
