using System;
using System.Collections.Generic;

namespace Day11And12Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int sumOfDigits = SumOfAllDigit.SumOfDigits(number);
            Console.WriteLine("Sum of digits of {0} is: {1}", number, sumOfDigits);
        }
        
    }
    
}
