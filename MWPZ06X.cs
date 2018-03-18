using System;

public class Test
{
	public static void Main()
	{
		// your code here
		int licz = int.Parse(Console.ReadLine());

            for (int i = 0; i < licz; i++)
            {
                int w = int.Parse(Console.ReadLine());
                w *= w;
                Console.WriteLine(w);
            }
	}
}