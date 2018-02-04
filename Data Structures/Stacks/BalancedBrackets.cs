using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Hacker rank solution for checking if brackets are balanced.
/// Author: Jitendra Selvam
/// </summary>

namespace StackBalancedBrackets
{
    class BalancedBrackets
    {
        static int[] result;
        static Stack<char> stack;
        static void Main(String[] args)
        {
            result = new int[3];
            stack = new Stack<char>();

            for(int i =0;i<=2;i++)
            {
                result[i] = 0;
            }
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                stack.Clear();
                char[] s = Console.ReadLine().ToCharArray();
                string result = isBalanced(s);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Function to check the brackets
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string isBalanced(char[] s)
        {
            foreach (char bracket in s)
            {
                switch (bracket)
                {
                    case ']':
                        {
                            if (stack.Count == 0)
                                return "NO";
                            if(!(stack.Peek()=='['))
                            {
                                return "NO";
                            }
                            else
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    case '}':
                        {
                            if (stack.Count == 0)
                                return "NO";
                            if (!(stack.Peek() == '{'))
                            {
                                return "NO";
                            }
                            else
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    case ')':
                        {
                            if (stack.Count == 0)
                                return "NO";
                            if (!(stack.Peek() == '('))
                            {
                                return "NO";
                            }
                            else
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    default:
                        {
                            stack.Push(bracket);
                            break;
                        }
                }
                
            }
            if (stack.Count == 0)
                return "YES";
            else
                return "NO";
        }
    }
}
