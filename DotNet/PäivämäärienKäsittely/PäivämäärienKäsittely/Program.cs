using System;
using System.Globalization;

namespace PäivämäärienKäsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna päivämäärä 1:");
            string syöte1 = Console.ReadLine();
            Console.WriteLine("Anna päivämäärä 2:");
            string syöte2 = Console.ReadLine();

            DateTime pvm1 = MuunnaPäivämäärä(syöte1);
            DateTime pvm2 = MuunnaPäivämäärä(syöte2);

            TimeSpan erotus = pvm2 - pvm1;
            Console.WriteLine($"Erotus: {erotus.TotalDays/7} viikkoa.");
            Console.WriteLine($"Erotus: {erotus.TotalDays} päivää.");
            Console.WriteLine($"Erotus: {erotus.TotalHours} tuntia.");
        }

        static DateTime MuunnaPäivämäärä(string syöte)
        {
            DateTime tulos;

            CultureInfo fiFi = new CultureInfo("fi-FI");
            CultureInfo enUS = new CultureInfo("en-US");
            try
            {
                tulos = DateTime.Parse(syöte, fiFi);
            }
            catch
            {
                tulos = DateTime.Parse(syöte, enUS);
            }

            return tulos;
        }
    }
}
