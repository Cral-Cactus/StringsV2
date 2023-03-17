using System;

namespace UnicodeSymbols
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            
            foreach (char c in input)
            {
                output += string.Format($"\\u{(int)c:X4}");
            }
            
            Console.WriteLine(output);
        }
    }
}