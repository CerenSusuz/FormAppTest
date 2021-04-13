using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] sayilar = new int[6]; //6 random sayı
            Console.Write("Kaç kolon istiyorsunuz? :");
            int kolon = Convert.ToInt32(Console.ReadLine());
            //kolon = satır
            
            Console.Clear();
            Console.WriteLine("----------------------");
                for (int i = 0; i < kolon; i++)
                {
                
                for (int j = 0; j < sayilar.Length; j++)
                {
                    int rnd2 = rnd.Next(1, 10);
                   
                    if (!sayilar.Contains(rnd2)) //Contains kullanmadan yapamadım
                    {
                        sayilar[j] = rnd2;
                        Console.Write($"{sayilar[j]}-");
                    }
                    else
                    {
                        j--;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
