using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile auto = new Automobile("oao3o11", "CA234FG", "volkswagen", "golf gti");
            auto.salitaguidatore();
            auto.accendi();
            auto.impostalimite(126);
            auto.acceleratore(130);
            Console.WriteLine("numero infrazioni eseguite 1: " + auto.ottieniinfrazioni());
            auto.decelerazione(20);
            auto.acceleratore(20);
            Console.WriteLine("numero infrazioni eseguite 1: " + auto.ottieniinfrazioni());
            auto.decelerazione(130);
            auto.salitapasseggero(3);
            Console.WriteLine("conteggio passeggeri 1: " + auto.ottienipasseggeri());
            auto.discesapasseggeri(2);
            Console.WriteLine("conteggio passeggeri 2: " + auto.ottienipasseggeri());
            auto.discesapasseggerosingolo();
            Console.WriteLine("conteggio passeggeri 2: " + auto.ottienipasseggeri());
            auto.spegni();
            auto.discesaguidatore();
        }
    }
}
