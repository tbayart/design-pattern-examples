using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class ButtonBase
    {
        private ButtonState m_state;

        public ButtonState State
        {
            get { return m_state; }
            set { m_state = value; }
        }
         
        public ButtonBase()
        {
            m_state = new PauseState();
        }

        public void PressPlayButton()
        {
            m_state.PlayButtonPressed(this);
        }

        public void PressPauseButton()
        {
            m_state.PauseButtonPressed(this);
        }
    }
}
