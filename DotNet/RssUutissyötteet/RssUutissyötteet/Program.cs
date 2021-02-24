using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RssUutissyötteet
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Haetaan uutisotsikkoja YLE:ltä...");

            HttpClient client = new HttpClient();
            const string YleRSSUrl = "https://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
            string rss = await client.GetStringAsync(YleRSSUrl);

            RssParser parser = new RssParser();
            IEnumerable<RssSchema> feed = parser.Parse(rss);

            int lkm = 0;
            foreach (RssSchema element in feed)
            {
                Console.WriteLine($"Title: {element.Title}");
                // Console.WriteLine($"Summary: {element.Summary}");

                lkm++;
                if (lkm > 10)
                {
                    break;
                }
            }
        }
    }
}
