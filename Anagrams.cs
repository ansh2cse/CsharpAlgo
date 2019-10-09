using System;
using System.Linq;

namespace CsharpAlgo
{
    /*
    Two words are said to be Anagrams of each other if they share the same set of letters to form the respective words.
    for an example: Silent–>Listen, post–>opts.
    */
    static class Anagrams
    {
        public static void IsEquals(string val1, string val2)
        {
            // chararter array
            char[] v1 = val1.ToLower().ToCharArray();
            char[] v2 = val2.ToLower().ToCharArray();

            Array.Sort(v1);
            Array.Sort(v2);

            string str1 = new string(v1);
            string str2 = new string(v2);

            if (str1 == str2)
            {
                Console.WriteLine("Yes Anagrams");
            }
            else
            {
                Console.WriteLine("No Anagrams!");
            }
        }

    }
}