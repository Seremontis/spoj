using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_pozycyjny
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            char[] szesnatk = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
           
            if (t>0 & t<1000000)
            {
                for (int i = 0; i < t; i++)
                {
                    string wynik1 = null, wynik2 = null;
                    int liczba1 = Convert.ToInt32(Console.ReadLine());
                    int liczba2 = liczba1;
                    do
                    {                    
                        if (liczba1<15)
                        {
                            int s = liczba1 % 16;
                            wynik1 = wynik1 + szesnatk[s];
                            liczba1 -= s;
                        }
                        else
                        {
                            int s = liczba1 % 16;
                            wynik1 = wynik1 + szesnatk[s];
                            liczba1 /= 16;
                        }

                    } while (liczba1!=0);

                    char[] w1 = wynik1.ToCharArray();
                    wynik1 = null;
                    Array.Reverse(w1);
                    foreach (var item in w1)
                    {
                        wynik1 += item;
                    }


                    do
                    {
                        if (liczba2 < 11)
                        {
                            int s = liczba2 % 11;
                            wynik2 = wynik2 + szesnatk[s];
                            liczba2 -= s;
                        }
                        else
                        {
                            int s = liczba2 % 11;
                            wynik2 = wynik2 + szesnatk[s];
                            liczba2 /= 11;
                        }

                    } while (liczba2 != 0);

                    

                    char[] w2 = wynik2.ToCharArray();
                    wynik2 = null;
                    Array.Reverse(w2);
                    foreach (var item in w2)
                    {
                        wynik2 += item;
                    }

                    Console.WriteLine(wynik1+" "+wynik2);

                }

                
                
            }
            Console.ReadKey();
        }
    }
}
