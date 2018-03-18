using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST3_spr42_
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int aktualna = 0;
            int stara = 0;
            int licznik=0;
            while ((x = Console.ReadLine()) != "")
            {
                aktualna = int.Parse(x);
                Console.WriteLine(aktualna);
                if (aktualna==42 && aktualna!=stara && stara!=0)
                {
                    licznik++;
                }
                if (licznik==3)
                {
                    break;
                }

                stara = aktualna;
            }
            Console.ReadKey();
        }
    }
}
