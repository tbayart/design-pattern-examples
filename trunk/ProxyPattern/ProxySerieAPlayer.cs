using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public class ProxySerieAPlayer
    {
        private SerieAPlayer m_serieAPlayer;

        public void Shoot()
        {
            // Lazy intiliazation
            if (m_serieAPlayer == null)
            {
                m_serieAPlayer = new SerieAPlayer();
            }
            m_serieAPlayer.Shoot();
        }
    }
}
