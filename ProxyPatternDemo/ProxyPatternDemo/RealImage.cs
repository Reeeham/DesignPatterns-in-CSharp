using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternDemo
{
    public class RealImage : Image
    {
        public string FileName { get; set; }
        public RealImage(string FileName)
        {
            this.FileName = FileName;
            LoadFromDisk(FileName);
        }
        private void LoadFromDisk(string FileName)
        {
            Console.WriteLine("Loading " + FileName);
        }

        public void display()
        {
            Console.WriteLine("Displaying " + FileName);
        }
    }
}
