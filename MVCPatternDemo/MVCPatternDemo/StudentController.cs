using System;
using System.Collections.Generic;
using System.Text;

namespace MVCPatternDemo
{
    public class StudentController
    {
        public Student Model { get; set; }
        public StudentView View { get; set; }

        public string RollNo { get; set; }
        public string Name { get; set; }

        public StudentController(Student Model, StudentView View)
        {
            this.Model = Model;
            this.View = View;
        }
        public void UpdateView()
        {
            View.printStudentDetails(Model.Name,Model.RollNo);
        }
     }
}
