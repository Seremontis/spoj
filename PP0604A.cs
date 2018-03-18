using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_arytm
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            bool b=false;
            if (t<101)
            {
                for (int i = 0; i < t; i++)
                {
                    double wynik = 0,odp;
                    string[] linia = Console.ReadLine().Split(' ');
                    int[] l = new int[linia.Length];
                    for (int u = 0; u < linia.Length; u++)
                    {
                        l[u] = Convert.ToInt32(linia[u]);
                        if (u==0)
                        {
                            if (l[u] < 0 && l[u] > 100)
                            {
                                b = true;
                                break;
                            }
                        }                      
                        else if(u>0)
                        {
                            if (l[u]<=100 && l[u]>=0)
                            {
                                wynik += l[u];
                            }
                            
                        }
                    }
                    wynik /= linia.Length-1;
                    odp = l[1];
                    if (b!=true)
                    {


                        for (int z = 2; z < linia.Length; z++)
                        {
                            if (Math.Abs(wynik - l[z]) < Math.Abs(wynik - odp))
                            {
                                odp = l[z];

                            }
                        }




                        Console.WriteLine(odp);
                    }

                }
            }


            Console.ReadKey();
        }
    }
}
