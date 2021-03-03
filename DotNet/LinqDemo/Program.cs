using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListanKäsittely();

            /*
            int[] luvut = { 5, 3, 10, 8, 4, 1, 9, 7, 2, 11 };

            // tehtävä: etsi viittä suuremmat luvut ja tulosta ne numerojärjestyksessä
            var tulokset = from l in luvut
                           where l > 5
                           orderby l
                           select l;
            
            foreach (int tulos in tulokset)
            {
                Console.WriteLine(tulos);
            }
            */

            /*
            // tehtävä: etsi viittä suuremmat luvut ja tulosta ne numerojärjestyksessä
            List<int> tulokset = new List<int>();
            foreach (int luku in luvut) {
                if (luku > 5) {
                    tulokset.Add(luku);
                }
            }

            tulokset.Sort();
            foreach (int tulos in tulokset) {
                Console.WriteLine(tulos);
            }
            */
        }

        private static void ListanKäsittely()
        {
            List<OmaLuokka> oliot = new List<OmaLuokka>()
            {
                new OmaLuokka() { Luku = 100, Nimi = "Matti", Kaupunki = "Oulu" },
                new OmaLuokka() { Luku = 101, Nimi = "Maija", Kaupunki = "Oulu" },
                new OmaLuokka() { Luku = 102, Nimi = "Keke", Kaupunki = "Kempele" },
                new OmaLuokka() { Luku = 103, Nimi = "Pena", Kaupunki = "Ivalo" },
                new OmaLuokka() { Luku = 104, Nimi = "Liisa", Kaupunki = "Helsinki" },
            };

            // tehtävä: etsi Oulussa olevat henkilöt
            // LINQ-kyselysyntaksi
            IEnumerable<OmaLuokka> tulokset = from o in oliot
                                              where o.Kaupunki == "Oulu"
                                              select o;

            // LINQ-metodisyntaksi
            IEnumerable<OmaLuokka> tulokset2 =
                oliot.Where(o => o.Kaupunki == "Oulu");

            foreach (OmaLuokka l in tulokset)
            {
                Console.WriteLine(l.Nimi);
            }

            foreach (OmaLuokka l in tulokset2)
            {
                Console.WriteLine(l.Nimi);
            }
        }
    }
}
