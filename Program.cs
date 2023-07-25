using System;
using System.Collections.Generic;
using System.Globalization;

namespace Day11And12Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a title";
            string capitalizedString = Capitalization.CapitalizeFirstLetter(inputString);
            string inputString2 = "Welcome to the RFP batch";
            string capitalizedString2 = Capitalization.CapitalizeFirstLetter(inputString2);
            Console.WriteLine("1st Words :"+capitalizedString+"\n2nd Words: "+capitalizedString2);
        }
        

    }
    
}
