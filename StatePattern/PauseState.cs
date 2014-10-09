using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class PauseState: ButtonState
    {
        public PauseState()
        {
            Console.WriteLine("Pause");
        }

        public override void PlayButtonPressed(ButtonBase buttonBase)
        {
            buttonBase.State = new PlayingState();
        }

        public override void PauseButtonPressed(ButtonBase buttonBase)
        {
            buttonBase.State = new PauseState();
        }
    }
}
