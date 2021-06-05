using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePatternDemo
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        //template method
        public void play()
        {

            //initialize the game
            initialize();

            //start game
            startPlay();

            //end game
            endPlay();
        }
    }
}
