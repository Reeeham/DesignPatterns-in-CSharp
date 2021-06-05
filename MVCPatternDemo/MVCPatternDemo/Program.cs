using System;

namespace MVCPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //fetch student record based on his roll no from the database
            Student model = RetriveStudentFromDatabase();

            //Create a view : to write student details on console
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            //update model data
            controller.Name = "John";

            Console.ReadLine();

        }
        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }
}
