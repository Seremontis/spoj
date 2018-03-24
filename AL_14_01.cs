using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_03_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string zdanie = Console.ReadLine().Trim().Replace(" ","");
            zdanie = zdanie.ToUpper();
            int ilosc = zdanie.Length;
            char[] litery = new char[26];
            int licznik = 0;
            for (int i = 65; i < 91; i++)
            {
                litery[licznik]= (char)i;
                licznik++;
            }
            licznik = 0;
            int wynik;
            for (int i = 0; i < 26; i++)
            {
                wynik = 0;
                licznik = 0;
                for (int z = 0; z < ilosc; z++)
                {
                    if (zdanie[z]==litery[i])
                    {
                        ++licznik;
                    }
                }
                Console.Write(litery[i]);
                wynik =(int)Math.Round((licznik / (double)ilosc)*100);
                for (int z = 0; z < wynik; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

           

        }
    }
}
