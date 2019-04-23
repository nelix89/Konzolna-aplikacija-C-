using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ZateznaKamata
    {
        public double glavnica;
        protected double godStopaZatKamate;
        protected int obracunskiPeriod;
        protected int brDanaUGodini;

        public ZateznaKamata()
        {
            glavnica = 400000;
            godStopaZatKamate = 4;
            obracunskiPeriod = 200;
            brDanaUGodini = 365;
        }
        public ZateznaKamata(double glavnica, double godStopaZatKamate,int obracunskiPeriod,int brDanaUGodini)
        {
            this.glavnica = glavnica;
            this.godStopaZatKamate = godStopaZatKamate;
            this.obracunskiPeriod = obracunskiPeriod;
            this.brDanaUGodini = brDanaUGodini;
        }
        public double IznosZatezneKamate()
        {
            return (glavnica * godStopaZatKamate * obracunskiPeriod) / (100 * brDanaUGodini);
        }
        public void IspisiIznos()
        {
            Console.WriteLine("Zatezna kamata iznosi: "+IznosZatezneKamate()+ " dinara.");
        }
    }
}
