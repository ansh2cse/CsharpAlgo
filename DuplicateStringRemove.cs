using System;

namespace CsharpAlgo
{
    static class DuplicateStringRemove
    {
        public static void RemoveDuplicateChars(string key)
        {
            string result = string.Empty;
            string dup = string.Empty;
            foreach (char value in key)
            {
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
                else
                {
                    dup += value;
                }
            }
            System.Console.WriteLine(result);
            System.Console.WriteLine(dup);
        }
    }
}