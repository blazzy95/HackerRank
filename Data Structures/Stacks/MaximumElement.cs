using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Hacker rank solution performing query operations 1.Insert 2.Pop 3. Print max element
/// Author: Jitendra Selvam
/// </summary>
namespace StackHackerRank
{
    class MaximumElement
    {
        static Stack<int> stack, maxElementStack;
        static void Main(string[] args)
        {
            stack = new Stack<int>();
            maxElementStack = new Stack<int>();
            int[] queryInt = new int[2];

            int n = Int32.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                string[] query = Console.ReadLine().Split(' ');

                for(int j=0;j<query.Length;j++)
                {
                    queryInt[j] = Int32.Parse(query[j]);
                }

                switch(queryInt[0])
                {
                    case 1:
                        {
                            stack.Push(queryInt[1]);
                            if(maxElementStack.Count == 0 || queryInt[1] >= maxElementStack.Peek())
                            {
                                maxElementStack.Push(queryInt[1]);
                            }
                            break;
                        }
                    case 2:
                        {
                            int popped = stack.Pop();
                            if(popped == maxElementStack.Peek())
                            {
                                maxElementStack.Pop();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(maxElementStack.Peek());
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
