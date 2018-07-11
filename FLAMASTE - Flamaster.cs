using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj
{
    class Program
    {


        static void Main(string[] args)
        {
            int ilosc =Convert.ToInt16(Console.ReadLine());
            char tymczasowa=(char)0;
            int licznik=1;
            string slowo = null, wynik = null;
            for (int i = 0; i < ilosc; i++)
            {
                slowo = Console.ReadLine();
                for (int y = 0; y <=slowo.Length; y++)
                {
                    if (y == 0)
                        tymczasowa = slowo[y];
                    else if (y == slowo.Length)
                    {
                        wynik += (char)tymczasowa;
                        if (licznik == 2)                       //mozna skrocic np do jednej metody
                            wynik += (char)tymczasowa;
                        else if (licznik > 2)
                            wynik += licznik.ToString();

                        tymczasowa = (char)0;
                        licznik = 1;
                    }
                    else
                    {
                        if (tymczasowa == slowo[y])
                            ++licznik;            
                        else
                        {
                            wynik += (char)tymczasowa;
                            if (licznik == 2)                       //mozna skrocic np do jednej metody
                                wynik += (char)tymczasowa;
                            else if (licznik > 2)
                                wynik += licznik.ToString();
                            licznik = 1;
                            tymczasowa = slowo[y];
                        }
                    }           
                }
                Console.WriteLine(wynik);
                wynik = null;
            }
            Console.ReadKey();
        }
    }
}
