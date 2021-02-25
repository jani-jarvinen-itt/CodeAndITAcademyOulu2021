using System;
using System.IO;
using System.Globalization;

namespace TiedostonLukujenSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string tiedosto = @"C:\Academy\Oulu\CodeAndIT2021\Git\CodeAndITAcademyOulu2021\DotNet\TiedostonLukujenSumma\Luvut.txt";

            float summa = 0.0f;
            int rivinumero = 1;
            CultureInfo enUS = new CultureInfo("en-US");
            string[] rivit = File.ReadAllLines(tiedosto);
            foreach (string rivi in rivit)
            {
                /*
                try
                {
                    float luku = float.Parse(rivi, enUS);
                    summa += luku;
                }
                catch
                {
                    // ei tehdä mitään
                }
                */

                string korjattuRivi = rivi.Replace(",", ".");
                bool muunnosOnnistui = float.TryParse(korjattuRivi, NumberStyles.Float, enUS, out float luku);
                if (muunnosOnnistui)
                {
                    summa += luku;
                }
                else
                {
                    Console.WriteLine($"Virhe rivillä {rivinumero}: \"{rivi}\"");
                }

                rivinumero++;
            }

            Console.WriteLine("Lukujen summa on: " + summa);
        }
    }
}
