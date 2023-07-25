using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class Reverse
    {
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
    }
}
