using System;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class FilterManager
    {

        FilterChain FilterChain;

        public FilterManager(Target Target)
        {
            FilterChain = new FilterChain();
            FilterChain.SetTarget(Target);
        }

        public void SetFilter(Filter Filter)
        {
            FilterChain.AddFilter(Filter);
        }
        public void FilterRequest(string request)
        {
            FilterChain.Execute(request);
        }
    }
}
