using System;
using System.Linq;

namespace CsharpAlgo
{
    static class RevserseString
    {
        public static void Reverse(string value)
        {
            string result = string.Empty;
            for (int i = value.Length; i > 0; i--)
            {
                result += value[i - 1];
            }
            System.Console.WriteLine(result);
        }
    }
}