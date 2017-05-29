using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_10
{
    class PopulationCounter
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string check = Console.ReadLine();
                if (check.Equals("report"))
                {
                    break;
                }
                string[] info = check.Split('|');
                string cityName = info[0];
                string countryName = info[1];
                long population = long.Parse(info[2]);
                if (data.ContainsKey(countryName))
                {
                    if (data[countryName].ContainsKey(cityName))
                    {
                        data[countryName][cityName] += population;
                    }
                    else
                    {
                        data[countryName].Add(cityName, population);
                    }
                }
                else
                {
                    data.Add(countryName, new Dictionary<string, long>());
                    data[countryName].Add(cityName, population);
                }
            }

            foreach (var item in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                long totalPop = 0;
                foreach (var pop in item.Value)
                {
                    totalPop += pop.Value;
                }
                Console.WriteLine("{0} (total population: {1})", item.Key, totalPop);
                foreach (var cities in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", cities.Key, cities.Value);
                }
            }
        }
    }
}