using System;

public class Test
{
	public static void Main()
	{
		// your code here
		string liczby;
            while ((liczby=Console.ReadLine())!=null)
            {
                string[]tab;
                tab =liczby.Split();

                for (int i = tab.Length-1; i >= 0; i--)
                {
                    Console.Write(tab[i]+' ');
                }
                Console.WriteLine();
            }

            Console.ReadKey();
	}
}