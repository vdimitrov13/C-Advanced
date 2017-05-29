using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dic = new SortedDictionary<char, int>();
            var chars = input.ToCharArray();

            foreach (var c in chars)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            foreach (var s in dic)
            {
                Console.WriteLine($"{s.Key}: {s.Value} time/s");
            }
        }
    }
}
