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

            ////Find Minimum number of coins needed to create an amount
            //List<int> list = new List<int>() { 1,10,8,265,24};
            //Console.WriteLine(MinimumCoins(271, list));

            ////Count Paths in a grid
            //List<List<char>> grid = new List<List<char>>();
            //grid.Add(new List<char>() { 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'X', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'X', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O'});
            //grid.Add(new List<char>() { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O'});
            //Console.WriteLine(FindPossiblePath(grid));

            //Max Path Sum
            List<List<int>> grid = new List<List<int>>();
            grid.Add(new List<int>() { 1, 1, 3, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 2, 1, 1, 6, 1, 1, 5, 1, 1, 0, 0, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 5, 1, 1, 1, 1, 0, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 2, 1, 1, 1, 1, 8, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 2, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 9, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 8, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(FindMaxPathSum(grid));
        }

        private static int FindMaxPathSum(List<List<int>> grid)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            return FindMaxPathSumRecursively(0, 0, grid, dict);
        }

        private static int FindMaxPathSumRecursively(int x, int y, List<List<int>> grid, Dictionary<string, int> dict)
        {
            if (x >= grid.Count) return 0;
            if (y >= grid[0].Count) return 0;
            if (dict.ContainsKey(x + "," + y)) return dict[x + "," + y];
            int downCount = FindMaxPathSumRecursively(x + 1, y, grid, dict);
            int rightCount = FindMaxPathSumRecursively(x, y + 1, grid, dict);
            int max = Math.Max(rightCount, downCount);
            dict.Add(x + "," + y, max + grid[x][y]);
            return dict[x + "," + y] ;
        }

        private static int FindPossiblePath(List<List<char>> grid)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            return FindPossiblePathRecursively(0, 0, grid, dict);
        }

        private static int FindPossiblePathRecursively(int x, int y, List<List<char>> grid, Dictionary<string, int> dict)
        {
            if (dict.ContainsKey(x + "," + y)) return dict[x + "," + y];
            if (x >= grid.Count) return 0;
            if (y >= grid[0].Count) return 0;
            if (grid[x][y] == 'X') return 0;
            if (x == grid.Count - 1 && y == grid[0].Count - 1) return 1;
            int rightCount = FindPossiblePathRecursively(x + 1, y, grid, dict);
            int downCount = FindPossiblePathRecursively(x, y + 1, grid, dict);
            dict.Add(x + "," + y, rightCount + downCount);
            return rightCount + downCount;
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

