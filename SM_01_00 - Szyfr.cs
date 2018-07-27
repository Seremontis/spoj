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
                int dlugosc = (slowo.Length / 5);
                string[] tablica = new string[dlugosc];
                int o = 0;


                for (int w = 0; w < dlugosc; w++)
               
                    {
 
                            tablica[w] = slowo.Substring(0, 5);
                            slowo = slowo.Remove(0, 5);

                      
                    }
            

            


                for (int t = 0; t < dlugosc; t++)
                {
                    double wynik = 0;
                    string spr = tablica[t];
                    if (spr != null)
                    {
                        int a = spr.Length;
                        for (int y = 0; y < a; y++)
                        {
                            if (spr[(a-1)-y] != '0')
                                wynik += Math.Pow(2, y);
                        }
                    }
                    char xxx = (char)(wynik + 65);
                        Console.Write(xxx);
                }
                        Console.WriteLine();
            }

                    Console.ReadKey();

        }
    }
}
