using NorthwindEFDemo.Models;
using System;
using System.Linq;

namespace NorthwindEFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext konteksti = new NorthwindContext();

            Console.WriteLine("Asiakkaiden lukumäärä tietokannassa:");
            Console.WriteLine(konteksti.Customers.Count());

            var ruotsalaiset = from c in konteksti.Customers
                               where c.Country == "Sweden"
                               orderby c.CompanyName
                               select c;

            foreach (Customer ruotsalainen in ruotsalaiset)
            {
                Console.WriteLine(ruotsalainen.CompanyName);
            }
        }
    }
}
