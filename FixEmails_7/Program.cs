using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var contactInfo = new Dictionary<string, string>();
            int counter = 1;
            var currentUser = input;

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    contactInfo.Add(input, "placeholder");
                    currentUser = input;
                }
                else
                {
                    var check = input.Substring(input.Length - 2);
                    if (check.Equals("us", StringComparison.CurrentCultureIgnoreCase) || check.Equals("uk", StringComparison.CurrentCultureIgnoreCase))
                    {
                        contactInfo.Remove(currentUser);
                    }
                    else
                    {
                        contactInfo[currentUser] = input;
                    }
                }
                counter++;
                input = Console.ReadLine();
            }

            foreach (var contact in contactInfo)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }

        }
    }
}
