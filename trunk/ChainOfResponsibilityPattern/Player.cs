using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Player
    {
        protected Player m_nextPlayer;
        public abstract void ThrowBall(int nbBatter);
        public void SetNextPlayer(Player nextPlayer)
        {
            m_nextPlayer = nextPlayer;
        }
    }
}
