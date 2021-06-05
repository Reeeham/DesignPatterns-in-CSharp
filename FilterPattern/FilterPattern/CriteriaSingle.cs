using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new  List<Person>();

            foreach(Person person in persons)
            {
                if (String.Compare(person.MaritalStatus, "SINGLE", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
    }

