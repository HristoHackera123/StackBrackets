using System.Diagnostics;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input to check palindrom: ");
            string input = Console.ReadLine();
            StackWay(input);
            ReverseWay(input);
        }
        static void StackWay(string input)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Stack<char> stack = new Stack<char>(input);
            foreach (char item in input)
            {
                if (item == stack.Peek())
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("It is palindrom");
            }
            else
            {
                Console.WriteLine("It is not palindrom");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        static void ReverseWay(string input)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string reversed = input;
            reversed.Reverse();
            string result = string.Compare(input, reversed) == 0 ? "Palindrom" : "Not Palindrom";
            Console.WriteLine(result);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
    }
}
