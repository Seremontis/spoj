using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_09_10___Parzyste_w_przedziale
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik =Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < licznik; i++)
            {
                string slowo = Console.ReadLine();
                int z = slowo.IndexOf(' ');
                int[] tab=new int[2];
                tab[0] = Convert.ToInt32(slowo.Substring(0, z));
                tab[1] = Convert.ToInt32(slowo.Substring(z, slowo.Length - z));
                int o = 0;

                for (int x = tab[0]+1; x < tab[1]; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write(x+" ");
                        o++;
                    }
                        
                }
                if (o == 0)
                {
                    Console.WriteLine("BRAK");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
