using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternDemo
{
    public class CareTaker
    {
        private List<Memento> MementoList = new List<Memento>();

        public void Add(Memento state)
        {
            MementoList.Add(state);
        }
        public Memento Get(int index)
        {
            return MementoList[index];
        }
    }
}
