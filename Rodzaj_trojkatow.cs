using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodztroj
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            while ((y = Console.ReadLine())!=null)
            {
                string[] t = y.Split();
                int[] tab = new int[3];
                int k = 0;
                for (int i = 0; i < 3; i++)
                {
                    tab[i] = int.Parse(t[i]);
                    if (tab[i]<10000)
                    {
                        k++;
                    }
                }
                if (k==3)
                {

                
                if (tab[0]+tab[1]<tab[2])
                {
                   Console.WriteLine("brak");
                }
                else  if (tab[0]==tab[1] && tab[1]==tab[2])
                    {
                        Console.WriteLine("ostrokatny");
                    }
                else
                {         
                    for (int i = 0; i < 3; i++)
                    {
                    tab[i] *= tab[i];
                    }
                    if (tab[0]+tab[1]==tab[2])
                    {
                        Console.WriteLine("prostokatny");
                    }
                    else
                    {
                    Console.WriteLine("rozwartokatny");
                    }
                }
                }
            }
            Console.ReadKey();
        }
    }
}
