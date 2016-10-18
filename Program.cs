using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksBalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- != 0)
            {
                string expression = Console.ReadLine().Trim();
                Stack stack = new Stack();
                bool isBalanced = true;
                foreach (char c in expression)
                {
                    if (c == '{' || c == '[' || c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (stack.Count != 0 && IsMatching((char)stack.Peek(), c))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                
                if (isBalanced && stack.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static bool IsMatching(char v, char c)
        {
            if (v == '{' && c == '}') return true;
            if (v == '[' && c == ']') return true;
            if (v == '(' && c == ')') return true;

            return false;
        }
    }
}
