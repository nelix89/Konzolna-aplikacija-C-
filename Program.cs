using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            ZateznaKamata z = new ZateznaKamata(400000, 4, 200, 365);
            z.IspisiIznos();
            KreditnaSposobnostPravnogLica k = new KreditnaSposobnostPravnogLica(1000000,400000);
            k.PravoNaKredit();
            Console.ReadLine();
        }
    }
}
