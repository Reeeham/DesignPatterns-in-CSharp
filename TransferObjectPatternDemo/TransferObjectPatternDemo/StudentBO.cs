using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TransferObjectPatternDemo
{
    public class StudentBO
    {

        //list is working as a database
        List<StudentVO> Students;
        public StudentBO()
        {
            Students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Robert",0);
            StudentVO student2 = new StudentVO("John", 1);

            Students.Add(student1);
            Students.Add(student2);

        }

        public void DeleteStudent(StudentVO student)
        {
            Students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.RollNo + ", deleted from database");
        }
        //retrive list of students from the database

        public List<StudentVO> GetAllStudents()
        {
            return Students;
        }

        public StudentVO GetStudent(int RollNo)
        {
            return Students[RollNo];
        }

        public void UpdateStudent(StudentVO student)
        {
             Students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + ", updated in the database");
        }
    }
}
