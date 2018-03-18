using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parzyste_nieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {

            int ilosc = int.Parse(Console.ReadLine());
            string[] liczby;
            for (int i = 0; i < ilosc; i++)
            {
                liczby = Console.ReadLine().Split();
                for (int x = 1; x <= int.Parse(liczby[0]); x++)
                {
                    if (x%2==0)
                    {
                        Console.Write(liczby[x]+" ");
                    }
                }
                for (int x = 1;  x <= int.Parse(liczby[0]);  x++)
                {
                    if (x % 2 != 0)
                    {
                        Console.Write(liczby[x]+" ");
                    }
                }
                Console.WriteLine();
            }
                

           

        }
    }
}
