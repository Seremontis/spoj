using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_03_18
{
    class AL_14_01
    {
        static void Main(string[] args)
        {
            int ilosc = Convert.ToInt32(Console.ReadLine());
            int wiersz, licznik = 0; ;
            
            string[] linia;
            for (int i = 0; i < ilosc; i++)
            {
                licznik = 0;
                wiersz = Convert.ToInt32(Console.ReadLine());
                linia = Console.ReadLine().Split();
                for (int x = 0; x < wiersz; x++)
                {
                    licznik ^= Convert.ToInt32(linia[x]);
                }
                Console.WriteLine(licznik);
            }
           

        }
    }
}
