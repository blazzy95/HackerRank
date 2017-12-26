using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Minimum Absolute Difference in an Array from Greedy Algorithm Hacker Rank solution.
/// Author: Jitendra Selvam
/// </summary>

namespace ConsoleApp1
{
    class MinAbsDiffArr
    {
        static int minimumAbsoluteDifference(int n, int[] arr)
        {
            // Complete this function
            Array.Sort(arr);
            int min = Int32.MaxValue;

            for(int i = 1; i<arr.Length;i++)
            {
                min = Math.Min(Math.Abs(arr[i]-arr[i-1]),min);
            }
            return min;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = minimumAbsoluteDifference(n, arr);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
