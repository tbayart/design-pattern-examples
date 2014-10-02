using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class CatcherNoda: Player
    {
        public override void ThrowBall(int nbBatter)
        {
            if (nbBatter > 10)
            {
                Console.WriteLine("Noda: Comme on, Gin.");
            }
            else if (m_nextPlayer != null)
            {
                Console.WriteLine("Noda: Somebody please help me.");
                m_nextPlayer.ThrowBall(nbBatter);
            }
        }
    }
}
