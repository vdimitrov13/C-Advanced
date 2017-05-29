using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var n = new HashSet<int>();
            var m = new HashSet<int>();
            var repeatingNumsSet = new HashSet<int>();
            var setLength = int.Parse(input[0]) + int.Parse(input[1]);

            for (int i = 0; i < setLength; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i <= int.Parse(input[0]) - 1)
                {
                    n.Add(num);
                }
                else
                {
                    m.Add(num);
                    if (n.Contains(num))
                    {
                        repeatingNumsSet.Add(num);
                    }
                }
            }
            Console.WriteLine();

            foreach (var num in repeatingNumsSet)
            {
                Console.WriteLine(num);
            }
        }
    }
}
