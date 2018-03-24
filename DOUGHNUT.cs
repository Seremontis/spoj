using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_03_18
{
    class DOUGHNUT
    {
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            int c, k, w;
            for (int i = 0; i < t; i++)
            {
                string[] dane = Console.ReadLine().Split();
                c = int.Parse(dane[0]);
                k = int.Parse(dane[1]);
                w = int.Parse(dane[2]);

                if (c * w <= k)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");            
            }
        }

    }
}
