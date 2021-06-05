using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    public class Subject
    {
        private int state;
        public int State { get { return state; } set { state = value; NotifyAllObservers(); } }
        private List<Observer> Observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }
        public void NotifyAllObservers()
        {
            foreach (Observer Observer in Observers)
            {
                Observer.Update();
            }
        }
    }
}
