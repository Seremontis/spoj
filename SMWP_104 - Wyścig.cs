using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMWP_104___Wyścig
{
    class Program
    {
        static int[] tab=new int[0];
        static int max = 0,licznik=0,dod=0;
        static bool czy = false;
        static void Sprawdzaj(int l)
        {
            max += l;
            for (int i = 0; i < licznik; i++)
            {
                if (max % tab[i] == 0)
                    czy = true;
                else
                   Sprawdzaj(dod);
            }

            
        }
        static void Main(string[] args)
        {
            licznik=Convert.ToInt32(Console.ReadLine());
            tab = new int[licznik];
            for (int i = 0; i < licznik; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < licznik; i++)
            {
                if (max < tab[i])
                   dod = max = tab[i];
            }
            Sprawdzaj(0);
            if (czy == true)
                Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
