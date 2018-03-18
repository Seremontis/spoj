using System;

namespace NWD
{
    class Program
    {
        static int NWD(int a,int b)
        {
            int pier = a;
            int drug = b;
            int x=0;
            int test;
            if ((a >= 0 && b >= 0) && (a <= 1000000 && b <= 1000000))
            {
                if (b < a)
                {
                    test = b;
                }
                else test = a;

                for (int i = test; i > 0; i--)
                {
                    if (b % i == 0 && a % i == 0)
                    {
                        x = i;
                        break;
                    }
                }
            }

            return x;
        }
        static void Main(string[] args)
        {
            int liczni = int.Parse(Console.ReadLine());
            int[] metoda = new int[liczni];
            string w;
            int a,b;
            string[] tab = new string[2];
            for (int i = 0; i < liczni; i++)
            {
                w= Console.ReadLine();
                tab =w.Split(' ');
                a=int.Parse(tab[0]);
                b=int.Parse(tab[1]);
                metoda[i]=NWD(a, b);
            }

            foreach (var item in metoda)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
