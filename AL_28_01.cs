using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_03_18
{
    class AL_26_04
    {
        static void Main(string[] args)
        {
            int ilosc = Convert.ToInt32(Console.ReadLine());
            string slowo = Console.ReadLine();

            int wynik = (ilosc / 2) ;
            int w2=wynik;


            do
            {
                for (int i = 0; i < slowo.Length; i++)
                {
                    if (i >= wynik && i <= w2)
                    {
                        Console.Write(slowo[i]);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                wynik--;
                w2++;

            } while (wynik>=0);
        }
    }
}
