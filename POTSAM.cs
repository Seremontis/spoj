using System;

public class Test
{
	public static void Main()
	{
		// your code here
		string linia = Console.ReadLine();
            string[] li;
            li =linia.Split(' ');

            int wynik=(Convert.ToInt32(li[0]))* (Convert.ToInt32(li[1]))+ (Convert.ToInt32(li[2]))* (Convert.ToInt32(li[3]));

            Console.WriteLine(wynik);

            Console.ReadKey();

	}
}