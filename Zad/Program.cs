using System;

namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put a combination of brackets: ");
            string input = Console.ReadLine();
            CheckBrackets(input);
        }
        static void CheckBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("The brackets arent balanced(1)");
                            return;
                        }
                        stack.Pop();
                        break;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("The brackets are all good");
            }
            else
            {
                Console.WriteLine("Brackets arent balanced");
            }
        }
    }
}
