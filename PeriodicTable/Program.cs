using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < input; i++)
            {
                var element = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < element.Length; j++)
                {
                    elements.Add(element[j]);
                }
            }
            Console.WriteLine();

            foreach (var e in elements)
            {
                Console.Write(e + " ");
            }
        }
    }
}
