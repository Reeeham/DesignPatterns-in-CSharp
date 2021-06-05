using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public virtual void  Draw()
        {
           decoratedShape.Draw();
        }
    }
}
