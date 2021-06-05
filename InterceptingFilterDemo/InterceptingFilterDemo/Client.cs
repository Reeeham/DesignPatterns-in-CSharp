using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class Client
    {
        FilterManager FilterManager;

        public void SetFilterManager(FilterManager FilterManager)
        {
            this.FilterManager = FilterManager;

        }
        public void SendRequest(string request)
        {
            FilterManager.FilterRequest(request);
        }
    }
}
