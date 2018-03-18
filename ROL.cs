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
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                string y = Console.ReadLine();
                string[] yz = y.Split();
                for (int v = 2; v < yz.Length; v++)
                {
                    Console.Write(yz[v] + " ");
                }           
                    Console.Write(yz[1]);
                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
