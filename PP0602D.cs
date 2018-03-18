using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROL
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] liczby = Console.ReadLine().Split();
            int n = Convert.ToInt32(liczby[0]);
            int k= Convert.ToInt32(liczby[1]);
           
                string[] wpisz = Console.ReadLine().Split();
                int licznik = wpisz.Count();
                int[] wynik = new int[licznik];
             
                for (int i = 0; i < licznik; i++)
                {
                if (i-k<0)
                {
                    wynik[licznik+(i - k)] = int.Parse(wpisz[i]);
                }
                else
                {
                    wynik[i - k] = int.Parse(wpisz[i]);
                }
                }
                
                for (int i = 0; i <licznik; i++)
                {
                    Console.Write(wynik[i] + " ");
                }
                
            

            
        }
    }
}
