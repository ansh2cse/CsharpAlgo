using System;

namespace CsharpAlgo
{
    /*
    Palindromes can be read in both directions.
    */
    static class Palindrome
    {
        public static void IsPalindrome(string word)
        {
            System.Console.WriteLine(IsPalin(word));
        }

        public static bool IsPalin(string word)
        {
            int min = 0;
            int max = word.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                if (word[min] != word[max])
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}