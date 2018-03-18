using System;

public class Test
{
	public static void Main()
	{
		// your code here
		int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                string y = Console.ReadLine();
                string[] yz = y.Split();
                for (int v = 2; v < yz.Length; v++)
                {
                    Console.Write(yz[v] + " ");
                }           
                    Console.Write(yz[1]);
                
                Console.WriteLine();
            }

            Console.ReadKey();
	}
}