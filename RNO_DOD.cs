using System;

public class Test
{
	public static void Main()
	{
		// your code here
		 string[]tab;
            int[]wynik;
            int t, w;

            t = int.Parse(Console.ReadLine());
            if(t>0 && t < 100)
            {
            wynik = new int[t];
            for (int i = 0; i < t; i++)
            {
                w= int.Parse(Console.ReadLine());
                tab = new string[w];

                string liczby=Console.ReadLine();
                tab = liczby.Split(' ');
                for (int x = 0; x < w; x++)
                {
                    wynik[i] += int.Parse(tab[x]);
                }
            }

            foreach (var item in wynik)
            {
                Console.WriteLine(item);
            }
           
            } 
            Console.ReadKey();
	}
}