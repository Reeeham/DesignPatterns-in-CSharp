using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach(Person person in persons)
            {
                if (String.Compare(person.Gender, "FEMALE", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
