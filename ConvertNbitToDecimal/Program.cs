using System;

namespace ConvertNbitToDecimal
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            
            int sourceBase = int.Parse(input[0]);
            string sourceNumber = input[1];

            int decimalNumber = 0;
            for (int i = 0; i < sourceNumber.Length; i++)
            {
                int digit = sourceNumber[i] - '0';
                decimalNumber = decimalNumber * sourceBase + digit;
            }

            Console.WriteLine(decimalNumber);
        }
    }
}