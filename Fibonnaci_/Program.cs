using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<ulong> fib = new Stack<ulong>();
            fib.Push(0);
            fib.Push(1);
            fib.Push(1);
            for (int i = 2; i < N; i++)
            {
                ulong s = fib.Pop();
                ulong f = fib.Pop();
                ulong X = s + f;
                fib.Push(f);
                fib.Push(s);
                fib.Push(X);
            }
            Console.WriteLine(fib.Peek());

        }
    }
}
