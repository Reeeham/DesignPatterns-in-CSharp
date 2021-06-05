using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DaoPatternDemo
{
    public class StudentDaoImpl : StudentDao
    {
        //list is working as a database
        List<Student> Students;

        public StudentDaoImpl()
        {
            Students = new List<Student>();
            Student Student1 = new Student("Robert", 0);
            Student Student2 = new Student("John", 1);
            Students.Add(Student1);
            Students.Add(Student2);
        }
        public void DeleteStudent(Student student)
        {
            Students.Remove(Students[student.RollNo]);
            Console.WriteLine("Student: Roll No " + student.RollNo + ", deleted from database");
        }

        //retrive list of students from the database
        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public Student GetStudent(int rollNo)
        {
            return Students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            Students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + ", updated in the database");
        }
    }
}
