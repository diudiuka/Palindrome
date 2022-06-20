using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var text = Console.ReadLine();
            int.TryParse(text, out int intText);

            var result = new Solution().IsPalindrome(intText);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string xStr = x.ToString();
            int stringLength = xStr.Length;
            int countOfComparition = stringLength / 2;
            for (int i = 0; i < countOfComparition; i++)
            {
                if (xStr[i] != xStr[stringLength - (i + 1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
