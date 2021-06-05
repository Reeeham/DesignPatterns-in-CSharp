using System;

namespace TransferObjectPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();
            //print all students
            foreach(StudentVO item in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + item.RollNo + ", Name : " + item.Name + " ]");
            }

            //update student
            StudentVO student = studentBusinessObject.GetAllStudents()[0];
            student.Name = "Michael";
            studentBusinessObject.UpdateStudent(student);

            //get the student
            student = studentBusinessObject.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.RollNo + ", Name : " + student.Name + " ]");

            Console.ReadLine();
        }
    }
}
