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

            ////Max Path Sum
            //List<List<int>> grid = new List<List<int>>();
            //grid.Add(new List<int>() { 1, 1, 3, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 2, 1, 1, 6, 1, 1, 5, 1, 1, 0, 0, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 5, 1, 1, 1, 1, 0, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 2, 1, 1, 1, 1, 8, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 2, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 9, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 8, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //grid.Add(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //Console.WriteLine(FindMaxPathSum(grid));

            //          //Max Non Adjacent Sum
            //          List<int> nums = new List<int>() { 72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
            //30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
            //83, 80, 56, 68,  6, 22, 56, 96, 77, 98,
            //61, 20,  0, 76, 53, 74,  8, 22, 92, 37,
            //30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
            //72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
            //42 };
            //          Console.WriteLine(FindNonAdjacentSum(nums));

            //Summing Squares
            //Console.WriteLine(FindSumSquares(31));

            ////Counting change
            //List<int> coins = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(CountChanges(240, coins));

            ////Array Stepper If it's possible to reach end of array
            //List<int> numbers = new List<int>() { 2, 4, 2, 0, 0, 1 };
            //Console.WriteLine(FindArrayStepper(numbers));

            //Max Palin Subsequence (Palindrome)
            Console.WriteLine(FindPalinSubsequence("chartreusepugvicefree"));
        }

        private static int FindPalinSubsequence(string str)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            return FindPalinSubsequenceRecursively(0, str.Length - 1, str, dict);
        }

        private static int FindPalinSubsequenceRecursively(int start, int end, string str, Dictionary<string, int> dict)
        {
            if (dict.ContainsKey(start + "," + end)) return dict[start + "," + end];
            if (start >= str.Length || end < 0 || start > end) return 0;
            if (start == end) return 1;
            int maxCount = 0;
            if (str[start] == str[end])
            {
                maxCount = Math.Max(maxCount, 2 + FindPalinSubsequenceRecursively(start + 1, end - 1, str, dict));
            }
            else {
                maxCount = Math.Max(maxCount, FindPalinSubsequenceRecursively(start + 1, end, str, dict));
                maxCount = Math.Max(maxCount, FindPalinSubsequenceRecursively(start, end - 1, str, dict));
            }
            dict.Add(start + "," + end, maxCount);
            return maxCount;
        }

        private static bool FindArrayStepper(List<int> numbers)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            return FindArrayStepperRercursively(0, numbers, dict);
        }

        private static bool FindArrayStepperRercursively(int pos, List<int> numbers, Dictionary<int, bool> dict)
        {
            if (dict.ContainsKey(pos)) return dict[pos];
            if (pos == numbers.Count - 1) return true;
            if (pos >= numbers.Count) return false;
            if (numbers[pos] == 0) return false;
            for (int i = 1; i <= numbers[pos]; i++) {
                if (FindArrayStepperRercursively(pos + i, numbers, dict))
                    return true;
            }

            dict.Add(pos, false);
            return false;
        }

        private static int CountChanges(int amount, List<int> coins)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            return CountChangesRecursively(amount, coins, dict);

        }

        private static int CountChangesRecursively(int amount, List<int> coins, Dictionary<string, int> dict, int i = 0)
        {
            string key = amount + "," + i;
            if (dict.ContainsKey(key)) return dict[key];
            if (amount == 0) return 1;
            if (i == coins.Count) return 0;
            int coin = coins[i];

            int total = 0;
            for (int qty = 0; (qty * coin) <= amount; qty++) {
                int remainder = amount - (qty * coin);
                total += CountChangesRecursively(remainder, coins, dict, i+1);
            }

            dict.Add(key, total);
            return total;
        }

        private static int FindSumSquares(int val)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return FindSumSquareRecursively(val, dict);
        }

        private static int FindSumSquareRecursively(int val, Dictionary<int, int> dict)
        {
            if (val == 0) return 0;
            if (dict.ContainsKey(val)) return dict[val];
            int min = int.MaxValue;
            for (int i = 1; i <= Math.Sqrt(val); i++) {
                int square = i * i;
                min = Math.Min(min, 1 + FindSumSquareRecursively(val-square, dict));
            }
            dict.Add(val, min);
            return min;
        }

        private static int FindNonAdjacentSum(List<int> nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            for (int i = 0; i < nums.Count; i++) {
                max = Math.Max(max, FindNonAdjacentSumRecursively(i, nums, dict));
            }
            return max;
        }

        private static int FindNonAdjacentSumRecursively(int x, List<int> nums, Dictionary<int, int> dict)
        {
            if (x >= nums.Count) return 0;
            if (dict.ContainsKey(x)) return dict[x];
            int max = 0;
            for (int i = x + 2; i < nums.Count; i++) {
                max = Math.Max(max, FindNonAdjacentSumRecursively(i, nums, dict));
            }
            dict.Add(x, max + nums[x]);
            return dict[x];
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

