using System;

public class Test
{
	public static void Main()
	{
		// your code here
		int t = int.Parse(Console.ReadLine());


            if (t < 100)
            {
                for (int i = 0; i < t; i++)
                {
                    string w2 = Console.ReadLine();
                    if (w2.Length == 11)
                    {
                        int test=0;
                        int w=0;
                        for (int x = 0; x < w2.Length; x++)
                        {
                            test = w2[x];
                       
                                if (x == 0 || x == 4 || x == 8 || x == 10)
                                {
                                    w = w + (test * 1);
                                }
                                else if (x == 1 || x == 5 || x == 9)
                                {
                                    w = w + (test * 3);
                                }
                                else if (x == 2 || x == 6)
                                {
                                    w = w + (test * 7);
                                }
                                else if (x == 3 || x == 7)
                                {
                                    w = w + (test * 9);
                                

                            }
                            
                        }
                        if (w % 10 == 0)
                            {
                                Console.WriteLine("D");
                            }
                            else Console.WriteLine("N");
                    }
                }
            }
            Console.ReadKey();
	}
}