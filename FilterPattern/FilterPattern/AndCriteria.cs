using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class AndCriteria : Criteria
    {
        private Criteria Criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria Criteria, Criteria otherCriteria)
        {
            this.Criteria = Criteria;
            this.otherCriteria = otherCriteria;
        }
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = Criteria.meetCriteria(persons);
            return otherCriteria.meetCriteria(firstCriteriaPersons);
        }
    }
}
