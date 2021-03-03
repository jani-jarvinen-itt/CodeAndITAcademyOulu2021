using System;
using System.Collections.Generic;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] luvut = { 5, 3, 10, 8, 4, 1, 9, 7, 2, 11 };
            
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
        }
    }
}
