using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagi_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            while ((linia=Console.ReadLine())!=null)
            {
                for (int i = 0; i < linia.Length; i++)
                {
                    if (linia[i]=='<')
                    {
                        i++;
                        
                            
                            
                         while (linia[i] != '>')
                        {
                                if (Convert.ToInt32(linia[i])>96 && Convert.ToInt32(linia[i]) < 123)
                                {
                                int z = Convert.ToInt32(linia[i]) - 32;
                                char zz = (char)z;
                                linia=linia.Insert(i, zz.ToString());
                                linia = linia.Remove(i+1,1);
                                
                                }
                            i++;
                        }
                    }
                }
                Console.WriteLine(linia);
            }
            Console.ReadLine();
        }
    }
}
