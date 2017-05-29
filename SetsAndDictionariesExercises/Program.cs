using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndDictionariesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < input; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }
            Console.WriteLine();

            foreach (var q in set)
            {
                Console.WriteLine(q);
            }
        }
    }
}
