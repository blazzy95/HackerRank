using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Ice Cream Parlor from Search Algorithm Hacker Rank solution.
/// Author: Jitendra Selvam
/// </summary>

namespace ConsoleApp6
{
    class IceCreamParlor
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t != 0)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] costsString = Console.ReadLine().Split(' ');
                int[] costs = new int[n];
                
                for(int i = 0; i < n; i++)
                {
                    costs[i] = Convert.ToInt32(costsString[i]);
                }

                SearchIceCreams(costs,m);

                t--;
            }
            Console.ReadKey();
        }

        private static void SearchIceCreams(int[] costs, int m)
        {
            bool flag = true;
            for(int i = 0;i < (costs.Length-1); i++)
            {
                for(int j = (i+1);j < costs.Length && flag; j++)
                {
                    if(costs[i]+costs[j]==m)
                    {
                        Console.WriteLine((i+1) + " " + (j+1));
                        flag = false;
                        break;
                    }
                }
            }
        }
    }
}
