using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pamiec = new int[10];
            string wpisz;
            string[] wartosci = new string[3];
            while ((wpisz=Console.ReadLine())!=null)
            {
                wartosci = wpisz.Split();
                int wart1 = int.Parse(wartosci[1]);
                int wart2 = int.Parse(wartosci[2]);
                if (wartosci[0]=="z")
                {
                    pamiec[wart1] = wart2;
                }
                else if (wartosci[0]=="+")
                {
                    Console.WriteLine(pamiec[wart1] + pamiec[wart2]);
                }
                else if (wartosci[0] == "-")
                {
                    Console.WriteLine(pamiec[wart1] - pamiec[wart2]);
                }
                else if (wartosci[0] == "/")
                {
                    Console.WriteLine(pamiec[wart1] / pamiec[wart2]);
                }
                else if (wartosci[0] == "*")
                {
                    Console.WriteLine(pamiec[wart1] * pamiec[wart2]);
                }
                else if (wartosci[0] == "%")
                {
                    Console.WriteLine(pamiec[wart1] % pamiec[wart2]);
                }
            }
                

           

        }
    }
}
