using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public interface Criteria
    {
        public List<Person> meetCriteria(List<Person> persons);

    }
}
