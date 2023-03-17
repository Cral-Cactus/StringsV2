using System;

namespace MultiplyStrings
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            string str1 = inputArr[0];
            string str2 = inputArr[1];

            int multiply = MultiplyStrings(str1, str2);
            Console.WriteLine(multiply);
        }

        static int MultiplyStrings(string str1, string str2)
        {
            int multiply = 0;

            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                int charCode1 = i < str1.Length ? (int)str1[i] : 1;
                int charCode2 = i < str2.Length ? (int)str2[i] : 1;

                multiply += charCode1 * charCode2;
            }

            return multiply;
        }
    }
}
