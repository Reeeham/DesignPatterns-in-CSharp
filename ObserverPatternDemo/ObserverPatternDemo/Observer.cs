using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    public abstract class Observer
    {
        protected Subject Subject;
        public abstract void Update();
    }

    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject Subject)
        {
            this.Subject = Subject;
            this.Subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(Subject.State));
        }
    }
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject Subject)
        {
            this.Subject = Subject;
            this.Subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(Subject.State));
        }
    }
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject Subject)
        {
            this.Subject = Subject;
            this.Subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Hex String: " + Convert.ToString(Subject.State));
        }
    }
}
