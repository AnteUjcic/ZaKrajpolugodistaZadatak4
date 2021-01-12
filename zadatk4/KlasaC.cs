using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatk4
{
   
    class KlasaC
    {
    
    
    
        public int Zbroj(int[] polje)
        {

            int priv=0;
            for(int i = 0; i <= 4; i++)
            {
                priv = polje[i] + priv;

            }

            return priv;
                

        }
        public double prosjek(int []poljeZaProsjek)
        {
            int privremenaVarijablaZaRacunanjeProsjekaBrojeva = 0;
            for (int i = 0; i <= 4; i++)
            {
                privremenaVarijablaZaRacunanjeProsjekaBrojeva = poljeZaProsjek[i] + privremenaVarijablaZaRacunanjeProsjekaBrojeva;

            }
            privremenaVarijablaZaRacunanjeProsjekaBrojeva = privremenaVarijablaZaRacunanjeProsjekaBrojeva / poljeZaProsjek.Length;

            return privremenaVarijablaZaRacunanjeProsjekaBrojeva;
        }



    }
}
