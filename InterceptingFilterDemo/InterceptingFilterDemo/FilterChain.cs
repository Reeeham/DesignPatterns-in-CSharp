using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterceptingFilterDemo
{
    public class FilterChain
    {
        private IList Filters = new ArrayList();
        private Target Target;

        public void AddFilter(Filter Filter)
        {
            Filters.Add(Filter);

        }

        public void Execute(string request)
        {
            foreach(Filter filter in Filters)
            {
                filter.execute(request);
            }
        }

        public void SetTarget(Target Target)
        {
            this.Target = Target;
        }
    }
}
