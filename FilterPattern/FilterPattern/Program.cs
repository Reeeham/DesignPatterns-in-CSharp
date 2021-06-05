using System;
using System.Collections.Generic;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Criteria Male = new CriteriaMale();
            Criteria Female = new CriteriaFemale();
            Criteria Single = new CriteriaSingle();
            Criteria SingleMale = new AndCriteria(Single, Male);
            Criteria SingleOrFemale = new OrCriteria(Single, Female);
            PrintPersons(Male.meetCriteria(persons));
            PrintPersons(Female.meetCriteria(persons));
            PrintPersons(SingleMale.meetCriteria(persons));
            PrintPersons(SingleOrFemale.meetCriteria(persons));

            Console.ReadLine();
        }
        public static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.Name + ", Gender : " + person.Gender + ", Marital Status : " + person.MaritalStatus + " ]");
            }
        }
    }
}
