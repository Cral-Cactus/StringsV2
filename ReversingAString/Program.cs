using System;

namespace ReversingAString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = ReverseString(input);
            
            Console.WriteLine(output);
        }

        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}