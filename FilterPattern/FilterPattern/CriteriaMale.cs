using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaMale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach(Person person in persons)
            {
                if (String.Compare(person.Gender, "MALE", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    malePersons.Add(person);
                }

            }
            return malePersons;
        }
    }
}
