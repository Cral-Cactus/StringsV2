using System;

namespace SumBigNumbers
{
    internal class Program
    {
        static void Main()
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            int maxLength = Math.Max(number1.Length, number2.Length);
            
            number1 = ReverseString(number1);
            number2 = ReverseString(number2);

            int carry = 0;
            string result = "";

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = i < number1.Length ? number1[i] - '0' : 0;
                int digit2 = i < number2.Length ? number2[i] - '0' : 0;
                
                int sum = digit1 + digit2 + carry;
                
                carry = sum / 10;
                
                result += (sum % 10).ToString();
            }
            
            if (carry != 0)
            {
                result += carry.ToString();
            }
            
            result = ReverseString(result);

            Console.WriteLine(result);
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}