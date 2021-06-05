using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo
{
    public class StartState : State

    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.State = this;
        }
        public override string ToString()
        {
            return "Start State";
        }
    }
}
