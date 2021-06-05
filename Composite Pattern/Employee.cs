using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Employee
    {
        public string Name { get; set; }

        public string Dept { get; set; }

        public int Salary { get; set; }

        public List<Employee> SubOrdinates { get; set; } /*= new List<Employee>();*/


        public Employee(string Name, string Dept, int Salary)
        {
            this.Name = Name;
            this.Dept = Dept;
            this.Salary = Salary;
            SubOrdinates = new List<Employee>();
        }
        public void Add(Employee e)
        {
            SubOrdinates.Add(e);
        }

        public void Remove(Employee e)
        {
            SubOrdinates.Remove(e);
        }
        public List<Employee> GetSubordinates()
        {
            return SubOrdinates;
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + Name + ", dept : " + Dept + ", salary :" + Salary + " ]");
        }
    }
}
