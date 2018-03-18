using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stos = new int[10];
            string wpisz;
            int x = 0;
            while ((wpisz = Console.ReadLine()) != null)
            {
                if (wpisz == "+")
                {
                    if (x < 10)
                    {

                        stos[x] = int.Parse(Console.ReadLine());
                        Console.WriteLine(":)");
                        x++;
                    }
                    else
                        Console.WriteLine(":(");
                }
                else if (wpisz == "-")
                {
                    x--;
                    if (x >= 0)
                    {

                        Console.WriteLine(stos[x]);

                    }
                    else
                    {
                        x = 0;
                        Console.WriteLine(":(");
                    }
                }

            }

        }
    }
}
