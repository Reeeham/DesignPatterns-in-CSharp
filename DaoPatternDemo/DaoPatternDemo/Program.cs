using System;

namespace DaoPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDaoImpl();

            //print all students
            foreach(Student s in studentDao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + s.RollNo + ", Name : " + s.Name + " ]");
            }

            // update student
            Student student = studentDao.GetAllStudents()[0];
            student.Name = "Michael";
            studentDao.UpdateStudent(student);

            //get the student 
            studentDao.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.RollNo + ", Name : " + student.Name + " ]");

            Console.ReadLine();

        }
    }
}
