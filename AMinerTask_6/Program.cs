using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

namespace AMinerTask_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var resourcesValues = new Dictionary<string, int>();
            int counter = 1;
            var currentResource = input;

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    if (!resourcesValues.ContainsKey(input))
                    {
                        resourcesValues.Add(input, 0);
                    }
                    currentResource = input;
                }
                else
                {
                    resourcesValues[currentResource] += int.Parse(input);
                }
                input = Console.ReadLine();
                counter++;
            }
            foreach (var entry in resourcesValues)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
            Console.WriteLine();

        }
    }
}
