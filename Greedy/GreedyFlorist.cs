using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Greedy Florist from Greedy Algorithm Hacker Rank solution.
/// Author: Jitendra Selvam
/// </summary>

namespace ConsoleApp4
{
    class GreedyFlorist
    {
        static int getMinimumCost(int n, int k, int[] c)
        {
            // Complete this function
            int totalCost = 0;
            int flowersBought = 0;
            int person = 0;
            var descendingCosts = c.OrderByDescending(i => i);
            foreach(int cost in descendingCosts)
            {
                totalCost = totalCost + (flowersBought + 1) * cost;
                person++;
                if(person == k)
                {
                    person = 0;
                    flowersBought++;
                }
            }
            return totalCost;
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int minimumCost = getMinimumCost(n, k, c);
            Console.WriteLine(minimumCost);
        }
    }
}
