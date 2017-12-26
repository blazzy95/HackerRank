using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Marc's CupCakes from Greedy Algorithm Hacker Rank solution.
/// Author: Jitendra Selvam
/// </summary>

namespace ConsoleApp9
{
    class MarcCupCakes
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] calories_temp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
            // your code goes here

            Array.Sort(calories);
            double miles = 0;
            int eaten = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                miles = (miles + (Math.Pow(2, eaten) * calories[i]));
                eaten++;
            }
            Console.WriteLine(miles);
            Console.ReadKey();
        }
    }
}
