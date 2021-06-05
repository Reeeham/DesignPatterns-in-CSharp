using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternDemo
{
    public class ProxyImage : Image
    {
        public RealImage RealImage { get; set; }
        public string FileName { get; set; }

        public ProxyImage(string FileName)
        {
            this.FileName = FileName;
        }
        public void display()
        {
            if (RealImage == null)
            {
                RealImage = new RealImage(FileName);
            }
            RealImage.display();
        }
    }
}
