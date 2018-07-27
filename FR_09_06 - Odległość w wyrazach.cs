using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ilosc; i++)
            {
                string slowo = Console.ReadLine();
                int p = 0,d=0;
                p = slowo[0];
                for (int y = 1; y < slowo.Length; y++)
                {
                    if (slowo[y] > d) d = slowo[y];
                    else if (slowo[y] < p) p = slowo[y];
                }

                Console.WriteLine(d - p);
            }
            Console.ReadKey();
        }
    }
}
