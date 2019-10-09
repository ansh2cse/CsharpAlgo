using System;

namespace CsharpAlgo
{
    static class WordCount
    {
        public static void Count(string x)
        {
            int result = 0;
            x = x.Trim();

            if (x == "")
                result = 0;

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
            {
                x = x.Replace("  ", " ");
            }

            foreach (string item in x.Split(" "))
            {
                result++;
            }
            System.Console.WriteLine(result);
        }
    }
}