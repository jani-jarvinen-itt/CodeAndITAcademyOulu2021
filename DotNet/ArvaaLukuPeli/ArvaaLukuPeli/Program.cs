using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa peliin!");

            Random random = new Random();
            int oikea = random.Next(1, 21);
            Console.WriteLine(oikea);

            int arvauskertoja = 0;
            while (arvauskertoja < 3)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                string syöte = Console.ReadLine();
                int arvaus = int.Parse(syöte);

                if (arvaus < oikea)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }
                else if (arvaus > oikea)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein, voitit pelin!");
                    break;
                }

                arvauskertoja++;
            }

            Console.WriteLine("Peli on päättynyt.");
        }
    }
}
