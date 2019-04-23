using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class KreditnaSposobnostPravnogLica:ZateznaKamata
    {
        
        private double kapital;
 
        public KreditnaSposobnostPravnogLica()
        {
            kapital = 1000000;    
        }
        public KreditnaSposobnostPravnogLica(double kapital, double glavnica)
        {
            this.kapital = kapital;
            this.glavnica = glavnica;
        }
        public void PravoNaKredit()
        {
            if (kapital > (2 * glavnica))
            { Console.WriteLine("Lice je kreditno sposobno. Kredit je odobren"); }
            else
            { Console.WriteLine("Lice nije kreditno sposobno. Kredit nije odobren");} 
        }
    }
}
