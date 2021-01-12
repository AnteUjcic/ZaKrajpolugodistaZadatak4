using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatk4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polje=new int[5];

            Console.WriteLine("upisite 5 brojeva: ");
            for (int i=0; i <= 4; i++)
            {
                
                 polje[i]=Convert.ToInt32(Console.In.ReadLine());
            }

            KlasaC zbrajanje = new KlasaC();
            KlasaC prosjek = new KlasaC();
            Console.Write("Zbroj vasih 5 brojeva: ");
            Console.WriteLine(zbrajanje.Zbroj(polje));
            Console.WriteLine();
            Console.Write("Prosjek vasih 5 brojeva: ");
            Console.WriteLine(prosjek.prosjek(polje));
            Console.ReadKey();
        }
    }
}
