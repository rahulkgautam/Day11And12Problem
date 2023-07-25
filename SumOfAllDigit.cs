using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class SumOfAllDigit
    {
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10; 
                sum += digit; 
                num /= 10; 
            }
            return sum;
        }
    }
}
