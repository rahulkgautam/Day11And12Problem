using System;
using System.Collections.Generic;
using System.Globalization;

namespace Day11And12Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, -5, 3, 8, -2, 1, 7 };
            int sumOfTwoLowestPositiveNumbers = LowestArray.FindSumOfTwoLowestPositiveNumbers(numbers);
            Console.WriteLine("Sum of the two lowest positive numbers: " + sumOfTwoLowestPositiveNumbers);
        }
        

    }
    
}
