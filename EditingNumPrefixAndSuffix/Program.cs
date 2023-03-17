using System;

namespace EditingNumPrefixAndSuffix
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string str = input[i];

                int num = 0;
                for (int j = 1; j < str.Length - 1; j++)
                {
                    if (char.IsDigit(str[j]))
                    {
                        num = num * 10 + (str[j] - '0');
                    }
                }

                if (char.IsUpper(str[0]))
                {
                    result += num / (str[0] - 'A' + 1);
                }
                else
                {
                    result += num * (str[0] - 'a' + 1);
                }

                if (char.IsUpper(str[str.Length - 1]))
                {
                    result -= str[str.Length - 1] - 'A' + 1;
                }
                else
                {
                    result += str[str.Length - 1] - 'a' + 1;
                }
            }

            Console.WriteLine(result.ToString("F2"));
        }
    }
}