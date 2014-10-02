using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class PitcherKunimi: Player
    {
        public override void ThrowBall(int nbBatter)
        {
            if (nbBatter < 5)
            {
                Console.WriteLine("Hiro: Comme on, Hideo.");
            }
            else if (m_nextPlayer!= null)
            {
                Console.WriteLine("Hiro: Noda, please help me.");
                m_nextPlayer.ThrowBall(nbBatter);
            }
        }
    }
}
