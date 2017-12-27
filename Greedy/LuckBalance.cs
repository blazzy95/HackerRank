using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Luck Balance from Greedy Algorithm Hacker Rank solution.
/// Author: Jitendra Selvam
/// </summary>

namespace ConsoleApp3
{
    class LuckBalance
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);
            int totalLuck = 0;

            List<int> contests = new List<int>();

            for(int i = 0;i<n;i++)
            {
                string[] inputContests = Console.ReadLine().Split(' ');
                int luck = Convert.ToInt32(inputContests[0]);
                int important = Convert.ToInt32(inputContests[1]);

                if(important == 0)
                {
                    totalLuck = totalLuck + luck;
                }
                else
                {
                    contests.Add(luck);
                }
            }

            var descendingContests = contests.OrderByDescending(i => i);
            int counter = 0;

            foreach(int contestLuck in descendingContests)
            {
                if(counter < k)
                {
                    totalLuck = totalLuck + contestLuck;
                }
                else
                {
                    totalLuck = totalLuck - contestLuck;
                }
                counter++;
            }

            Console.WriteLine(totalLuck);
            Console.Read();
        }
    }
}
