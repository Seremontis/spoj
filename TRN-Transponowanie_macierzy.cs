using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRN_Transponowanie_macierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wymiary = Console.ReadLine().Split();
            int m = int.Parse(wymiary[0]);
            int n = int.Parse(wymiary[1]);
            int[,] tab = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] linia = Console.ReadLine().Split();
                for (int y = 0; y < n; y++)
                {
                    tab[i, y] = int.Parse(linia[y]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < m; y++)
                {
                    Console.Write(tab[y, i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
