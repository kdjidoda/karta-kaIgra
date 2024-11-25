using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraKartama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta = 0;
            int cardCounter = 0;
            Console.WriteLine("Unesi kartu s brojem izmedju 1 i 13:");
            while (cardCounter < 31)
            {


                karta = Convert.ToInt32(Console.ReadLine());


                if (karta <= 13 && karta >= 1)
                {
                    cardCounter += karta;
                }
                else
                {
                    Console.WriteLine("Unesi ispravnu kartu od 1 do 13");
                }
            }
            if (cardCounter > 31)
            {
                Console.WriteLine("Poraz.");

            }
            else if (cardCounter == 31)
            {
                Console.WriteLine("Pobjeda!");
            }
            Console.ReadKey();




        }
    }
}