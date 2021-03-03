using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı üretelim:");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];

            
            Random rnd = new Random();

            sayilar[0] = rnd.Next(0, 5);

            for (int i = 1; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 5);
                for (int b = 0; b<i; b++)
                {
                    if (sayilar[b]==sayilar[i])
                    {
                        i--;
                        break;
                    }
                }
            }
           
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{ sayilar[i]}-");
            }
            Console.ReadKey();
        }
    }
    
}
