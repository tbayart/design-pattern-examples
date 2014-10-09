using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public abstract class ButtonState
    {
        public abstract void PlayButtonPressed(ButtonBase buttonBase);
        public abstract void PauseButtonPressed(ButtonBase buttonBase);
    }
}
