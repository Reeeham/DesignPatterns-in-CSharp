using System;
using System.Collections.Generic;
using System.Text;

namespace TransferObjectPatternDemo
{
    public class StudentVO
    {
        public string Name { get; set; }

        public int  RollNo { get; set; }

        public StudentVO(string Name,int RollNo)
        {
            this.Name = Name;
            this.RollNo = RollNo;
        }
    }
}
