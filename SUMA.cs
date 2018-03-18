using System;

public class Test
{
	public static void Main()
	{
		// your code here
		int w = 0,y;
            string z;
            while ((z=Console.ReadLine()) != null)
            {
                y = int.Parse(z);
                w += y;
                Console.WriteLine(w);
            }

            Console.ReadKey();
	}
}