using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            bool isPalindrome = IsPalindrome(input);
            
            Console.WriteLine(isPalindrome);
        }

        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}