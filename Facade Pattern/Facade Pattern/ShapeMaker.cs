using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class ShapeMaker
    {
        public Shape Rectangle { get; set; }

        public Shape Circle { get; set; }

        public Shape Square { get; set; }

        public ShapeMaker()
        {
            Rectangle = new Rectangle();
            Circle = new Circle();
            Square = new Square();
        }
        public void DrawCircle()
        {
            Circle.draw();
        }
        public void DrawRectangle()
        {
            Rectangle.draw();
        }
        public void DrawSquare()
        {
            Square.draw();
        }

    }
}
