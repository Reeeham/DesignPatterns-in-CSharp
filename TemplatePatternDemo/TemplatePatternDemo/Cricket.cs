using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePatternDemo
{
    public class Cricket : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        public override void initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
       
    }
}
