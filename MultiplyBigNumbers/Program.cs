using System;

namespace MultiplyBigNumbers
{
    internal class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            string result = Multiply(num1, num2);

            Console.WriteLine(result);
        }

        static string Multiply(string num1, int num2)
        {
            if (num1 == "0" || num2 == 0)
            {
                return "0";
            }

            num1 = ReverseString(num1);

            string result = "";
            int carry = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                int digit = num1[i] - '0';
                int product = digit * num2 + carry;

                result = (product % 10).ToString() + result;
                carry = product / 10;
            }

            if (carry > 0)
            {
                result = carry.ToString() + result;
            }

            return result;
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
