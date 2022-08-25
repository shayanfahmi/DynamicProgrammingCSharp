using System;
using System.Collections.Generic;

namespace DynamicProgrammingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(46));
        }

        private static int Fibonacci(int num)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            dict.Add(1,1);
            return FindFibonacci(num, dict);
        }

        private static int FindFibonacci(int num, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(num)) return dict[num];

            int fib = FindFibonacci(num - 1, dict) + FindFibonacci(num - 2, dict);

            dict.Add(num, fib);

            return dict[num];
        }

    }
}

