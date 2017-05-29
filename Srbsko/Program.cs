using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srbsko
{
    class Program
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "End")
            {
                var venueTokens = line
                    .Split(new [] {" @"}, StringSplitOptions.RemoveEmptyEntries);

                if (!(venueTokens.Length > 1))
                {
                    line = Console.ReadLine();
                    continue;
                }
                var singer = venueTokens[0];

                var venueTickets = venueTokens[1].Split(' ');
                int ticketPrice = 0;
                int ticketCount = 0;

                try
                {
                    ticketPrice = int.Parse(venueTickets[venueTickets.Length - 2]);
                    ticketCount = int.Parse(venueTickets[venueTickets.Length - 1]);
                }
                catch (Exception e)
                {
                    line = Console.ReadLine();
                    continue;
                }
                var venue = new StringBuilder();

                for (int i = 0; i < venueTickets.Length - 2; i++)
                {
                    venue.Append(venueTickets[i]);
                    venue.Append(" ");
                }

                if (venues.ContainsKey(venue.ToString()))
                {
                    if (venues[venue.ToString()].ContainsKey(singer))
                    {
                        venues[venue.ToString()][singer] += ticketPrice * ticketCount;
                    }
                    else
                    {
                        venues[venue.ToString()].Add(singer, ticketPrice * ticketCount);
                    }
                }
                else
                {
                        venues[venue.ToString()] = new Dictionary<string, int>() { { singer, ticketPrice * ticketCount } }; 
                }
                line = Console.ReadLine();
            }
            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
