using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenStars.App
{
    class Program
    {
        static void Main(string[] args)
        { 
              //Ekranda '* * * * *' yazdırmak için
              //Tanımladığımız i ve j değerleri aynı türden yani i tekse j de tek, i çiftse j de çift olmalı.
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();

        }
    }
}
