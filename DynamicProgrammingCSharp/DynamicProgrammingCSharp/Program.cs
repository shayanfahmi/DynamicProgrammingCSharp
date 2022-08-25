using System;
using System.Collections.Generic;

namespace DynamicProgrammingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci
            //Console.WriteLine(Fibonacci(46));

            //Tribonacci
            Console.WriteLine(Tribonacci(37));
        }

        private static int Tribonacci(int num)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            dict.Add(1, 0);
            dict.Add(2, 1);
            return FindTribonacci(num, dict);
        }

        private static int FindTribonacci(int num, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(num)) return dict[num];
            int trib =
                FindTribonacci(num - 1, dict) +
                FindTribonacci(num - 2, dict) +
                FindTribonacci(num - 3, dict);
            dict.Add(num, trib);

            return dict[num];
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

