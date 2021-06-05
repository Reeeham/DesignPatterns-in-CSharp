using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public interface Filter
    {

        public void execute(string Request);
    }
}
