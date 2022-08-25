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
            //Console.WriteLine(Tribonacci(37));

            //Find if sum is possible by summing up the values in array
            //List<int> list = new List<int>() { 5,1,12 };
            //Console.WriteLine(FindPossibleSum(8, list));

            //Find Minimum number of coins needed to create an amount
            List<int> list = new List<int>() { 1,10,8,265,24};
            Console.WriteLine(MinimumCoins(271, list));
        }

        private static int MinimumCoins(int amount, List<int> list)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            return MinCoinsRecursion(amount, list, dict);
        }

        private static int MinCoinsRecursion(int amount, List<int> list, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(amount)) return dict[amount];
            if (amount < 0) return -1;
            if (amount == 0) return 0;

            int min = int.MaxValue;
            foreach (var item in list)
            {
                var curr = MinCoinsRecursion(amount - item, list, dict);
                if (curr != -1 ) {
                    curr = curr + 1;
                    min = Math.Min(min, curr);
                }
            }
            if (min == int.MaxValue) min = -1;
            dict.Add(amount, min);
            return dict[amount];
        }

        private static bool FindPossibleSum(int val, List<int> list)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            dict.Add(0, true);

            return FindPossibleSumRecursively(val, list, dict);
        }

        private static bool FindPossibleSumRecursively(int val, List<int> list, Dictionary<int, bool> dict)
        {
            if (dict.ContainsKey(val)) return dict[val];
            if (val < 0) return false;
            if (val == 0) return true;
            foreach (var item in list)
            {
                if (FindPossibleSumRecursively(val - item, list, dict)) {
                    dict.Add(val, true);
                    return true;
                }
            }
            dict.Add(val, false);
            return false;
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

