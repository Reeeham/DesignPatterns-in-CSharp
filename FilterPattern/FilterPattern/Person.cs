using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    //A class on which criteria is to be applied.
    public class Person
    {

        public string Name { get; set; }

        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        public Person(string Name, string Gender, string MaritalStatus)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.MaritalStatus = MaritalStatus;

        }

    }
}
