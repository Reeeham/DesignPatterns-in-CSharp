using System;
using System.Collections.Generic;
using System.Text;

namespace DaoPatternDemo
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public Student(string Name,int RollNo)
        {
            this.Name = Name;
            this.RollNo = RollNo;
        }
    }
}
