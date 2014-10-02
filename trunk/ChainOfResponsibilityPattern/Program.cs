using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// - Multi object handle a process
    /// - Ex: Pitcher Hiro Kunimi throws ball. If Kun vs Hideo, ok. Else Noda (next player) helps him.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Player kunimi = new PitcherKunimi();
            Player noda = new CatcherNoda();
            kunimi.SetNextPlayer(noda);
            kunimi.ThrowBall(3);
            Console.WriteLine("-------------");
            kunimi.ThrowBall(17); // print if set next player for kunimu
            Console.WriteLine("-------------");
            noda.ThrowBall(11); // print nothing
            Console.ReadKey();
        }
    }
}
