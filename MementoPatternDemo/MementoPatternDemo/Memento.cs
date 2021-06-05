using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternDemo
{
    public class Memento
    {
        public string State { get; }

        public Memento(string State)
        {
            this.State = State;
        }
    }
}
