using System;

public class Test
{
	public static void Main()
	{
		// your code here
		string linia;

            while ((linia = Console.ReadLine()) != null)
            {

                linia=linia.Replace('.', ',');
                string[] li;
                li = linia.Split(' ');

                double a = double.Parse(li[0]);
                double b = double.Parse(li[1]);
                double c = double.Parse(li[2]);

                int wynik;
                
                if (a + b > c && a + c > b && c + b > a)
                {
                     wynik = 1;
                }
                
                else
                {
                    wynik = 0;
                }
                Console.WriteLine(wynik);
            }
            Console.ReadKey();
	}
}