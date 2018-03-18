using System;

public class Test
{
	public static void Main()
	{
		// your code here
		 string liczby;
            while ((liczby=Console.ReadLine())!=null)
            {
                string[] licz = liczby.Split();
                int spr=0;
                int[] l = new int[licz.Length];
                for (int i = 0; i < licz.Length; i++)
                {
                    l[i] = int.Parse(licz[i]);
                }
                for (int i = 2; i < l.Length; i++)
                {
                    if (l[i]==l[0])
                    {
                        spr++;
                    }
                }

                Console.WriteLine(spr);
            }
	}
}