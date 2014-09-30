using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public class SerieAPlayer : Player
    {
        public override void Shoot()
        {
            Console.WriteLine("A strike is shotting!");
        }

        /// <summary>
        /// This method is not exposed in proxy
        /// </summary>
        public override void Hand()
        {
            Console.WriteLine("A goalkepper is handing!");
        }
    }
}
