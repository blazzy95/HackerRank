using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackHackerRank1
{
    class undoOperations
    {
        public int queryNum;
        public string query;

        public undoOperations(int queryNum, string query)
        {
            this.queryNum = queryNum;
            this.query = query;
        }
    }

    class SimpleTextEditor
    {
        static Stack<undoOperations> undoStack;
        static void Main(string[] args)
        {
            int queryInt;
            undoStack = new Stack<undoOperations>();
            StringBuilder s = new StringBuilder();

            int q = Int32.Parse(Console.ReadLine());

            for(int i=0;i<q;i++)
            {
                string[] query = Console.ReadLine().Split(' ');

                queryInt = Int32.Parse(query[0]);

                switch (queryInt)
                {
                    case 1:
                        {
                            s.Append(query[1]);
                            undoStack.Push(new undoOperations(queryInt,query[1]));
                            break;
                        }
                    case 2:
                        {
                            string str = s.ToString(s.Length - Int32.Parse(query[1]), Int32.Parse(query[1]));
                            //s.Length - Int32.Parse(query[1]), Int32.Parse(query[1])
                            s.Remove(s.Length - Int32.Parse(query[1]), Int32.Parse(query[1]));
                            undoStack.Push(new undoOperations(queryInt,str));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(s[Int32.Parse(query[1])-1]);
                            break;
                        }
                    case 4:
                        {
                            undoOperations operation = undoStack.Pop();
                            if(operation.queryNum ==1)
                            {
                                s.Remove(s.Length - operation.query.Length, operation.query.Length);
                            }
                            else
                            {
                                s.Append(operation.query);
                            }
                            break;
                        }
                }
            }
            Console.Read();
        }
    }
}
