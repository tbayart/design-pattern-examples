using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class PlayingState: ButtonState
    {
        public PlayingState()
        {
            Console.WriteLine("Play");
        }

        public override void PauseButtonPressed(ButtonBase buttonBase)
        {
            buttonBase.State = new PauseState();
        }

        public override void PlayButtonPressed(ButtonBase buttonBase)
        {
            buttonBase.State = new PlayingState();
        }
    }
}
