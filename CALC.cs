using System;

public class Test
{
	public static void Main()
	{
		// your code here
		string x;
            while ((x=Console.ReadLine())!=null)
            {
                string[] tab = x.Split();

                switch (tab[0])
                {
                    case "+":
                        Console.WriteLine(Convert.ToInt32(tab[1]) + Convert.ToInt32(tab[2]));
                        break;
                    case "-":
                        Console.WriteLine(Convert.ToInt32(tab[1]) - Convert.ToInt32(tab[2]));
                        break;
                    case "/":
                        Console.WriteLine(Convert.ToInt32(tab[1]) / Convert.ToInt32(tab[2]));
                        break;
                    case "*":
                        Console.WriteLine(Convert.ToInt32(tab[1]) * Convert.ToInt32(tab[2]));
                        break;
                    case "%":
                        Console.WriteLine(Convert.ToInt32(tab[1]) % Convert.ToInt32(tab[2]));
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
	}
}