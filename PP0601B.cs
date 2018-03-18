using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podzielnosc
{
    class Program
    {
        static void Main(string[] args)
        {

            

            
            int t = Convert.ToInt32(Console.ReadLine());
            if(t>1 && t< 100000) {
                for (int i = 0; i < t; i++)
                {
                    string[] liczby = Console.ReadLine().Split(' ');


                    int n = int.Parse(liczby[0]);
                    int x = int.Parse(liczby[1]);
                    int y = int.Parse(liczby[2]);

                    for (int b = 1; b < n;b++)
                    {
                        if (b%x==0 && b%y!=0)
                        {
                            Console.Write(b + " ");
                        }
                    }
                    Console.WriteLine();
                }
            
            
            Console.ReadKey();


            }
            else
            {
                return ;
            }
            
        }
    }
}
