using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class OrCriteria : Criteria
    {
        private Criteria Criteria;
        private Criteria OtherCriteria;


        public OrCriteria(Criteria Criteria, Criteria OtherCriteria)
        {
            this.Criteria = Criteria;
            this.OtherCriteria = OtherCriteria;
        }
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = Criteria.meetCriteria(persons);
            List<Person> otherCriteriaItems = OtherCriteria.meetCriteria(persons);

            foreach(Person person in otherCriteriaItems)
            {
                if(!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }

            }
            return firstCriteriaItems;
        }
    }
}
