using System;
using System.Linq;

namespace MagicChangingWords
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            string s1 = input[0];
            string s2 = input[1];

            bool replaceable = AreStringsReplaceable(s1, s2);

            Console.WriteLine(replaceable);
        }

        static bool AreStringsReplaceable(string str1, string str2)
        {
            if (str1.Length != str2.Length && str2.Length > str1.Distinct().Count())
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                char c1 = str1[i];
                char c2 = str2[i];

                if (c1 != c2)
                {
                    if (str1.IndexOf(c1) != str2.IndexOf(c2))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}