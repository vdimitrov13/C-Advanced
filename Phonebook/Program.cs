using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            var searchNames = new List<string>();

            while (input != "search")
            {
                var contactInfo = input.Split('-');
                if (!phonebook.ContainsKey(contactInfo[0]))
                {
                    phonebook.Add(contactInfo[0], contactInfo[1]);
                }
                else
                {
                    phonebook[contactInfo[0]] = contactInfo[1];
                }

                input = Console.ReadLine();
            }

            while (input != "stop")
            {
                if (input != "search")
                {
                    searchNames.Add(input);
                }
                input = Console.ReadLine();
            }

            foreach (var name in searchNames)
            {

                if (phonebook.ContainsKey(name))
                {
                    string test;
                    if (phonebook.TryGetValue(name, out test))
                    {
                        Console.WriteLine($"{name} -> {test}");
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}
