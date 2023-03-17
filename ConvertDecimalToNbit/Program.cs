using System;

namespace ConvertDecimalToNbit
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int targetBase = int.Parse(input[0]);
            int decimalNumber = int.Parse(input[1]);

            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % targetBase;
                result = remainder.ToString() + result;
                decimalNumber /= targetBase;
            }

            Console.WriteLine(result);
        }
    }
}