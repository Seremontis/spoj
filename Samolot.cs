using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samolot
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia = Console.ReadLine();
            string[] li;
            li =linia.Split(' ');

            int wynik=(Convert.ToInt32(li[0]))* (Convert.ToInt32(li[1]))+ (Convert.ToInt32(li[2]))* (Convert.ToInt32(li[3]));

            Console.WriteLine(wynik);

            Console.ReadKey();

        }
    }
}
