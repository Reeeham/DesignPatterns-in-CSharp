using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternDemo
{
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento Memento)
        {
            State = Memento.State;
        }
    }
}
