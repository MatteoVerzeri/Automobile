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
            auto.acceleratore(20);
            auto.decelerazione(20);
            auto.salitapasseggero(3);
            auto.discesapasseggeri(2);
            auto.discesapasseggerosingolo();
            auto.spegni();
            auto.discesaguidatore();
        }
    }
}
