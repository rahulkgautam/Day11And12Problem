using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Day11And12Problem
{
    class Capitalization
    {
        public static string CapitalizeFirstLetter(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
           
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }            
            return string.Join(" ", words);
        }
    }
}
