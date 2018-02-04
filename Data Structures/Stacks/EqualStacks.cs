using System;
using System.Collections.Generic;

/// <summary>
/// Equal Stacks hacker rank solution
/// Author: Jitendra Selvam
/// </summary>

namespace stackHackerRank
{
    class EqualStacks
    {
        static Stack<int> s1, s2, s3;
        static void Main(String[] args)
        {
            string[] tokens_n1 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n1[0]);
            int n2 = Convert.ToInt32(tokens_n1[1]);
            int n3 = Convert.ToInt32(tokens_n1[2]);
            string[] h1_temp = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(h1_temp, Int32.Parse);
            string[] h2_temp = Console.ReadLine().Split(' ');
            int[] h2 = Array.ConvertAll(h2_temp, Int32.Parse);
            string[] h3_temp = Console.ReadLine().Split(' ');
            int[] h3 = Array.ConvertAll(h3_temp, Int32.Parse);
            int min;
            s1 = new Stack<int>();
            s2 = new Stack<int>();
            s3 = new Stack<int>();
            int ht1 = 0,ht2 = 0,ht3 = 0;

            //initilizing the stacks
            for(int i = h1.Length-1;i>=0;i--)
            {
                s1.Push(h1[i]);
                ht1 += h1[i];
            }
            for (int i = h2.Length - 1; i >= 0; i--)
            {
                s2.Push(h2[i]);
                ht2 += h2[i];
            }
            for (int i = h3.Length - 1; i >= 0; i--)
            {
                s3.Push(h3[i]);
                ht3 += h3[i];
            }


            min = Math.Min(Math.Min(ht1,ht2),ht3);

            while(!(ht1 == ht2 && ht1 == ht3))
            {
                while(ht1 > min)
                {
                    ht1 -= s1.Pop();
                }
                while (ht2 > min)
                {
                    ht2 -= s2.Pop();
                }
                while (ht3 > min)
                {
                    ht3 -= s3.Pop();
                }
                min = Math.Min(Math.Min(ht1, ht2), ht3);
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
