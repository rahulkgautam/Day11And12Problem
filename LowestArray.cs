using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Day11And12Problem
{
    class LowestArray
    {
        public static int FindSumOfTwoLowestPositiveNumbers(int[] numbers)
        {
            
            int lowestPositive = int.MaxValue;
            int secondLowestPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    if (num < lowestPositive)
                    {
                        secondLowestPositive = lowestPositive;
                        lowestPositive = num;
                    }
                    else if (num < secondLowestPositive)
                    {
                        secondLowestPositive = num;
                    }
                }
            }

            // Calculate the sum of the two lowest positive numbers
            int sum = lowestPositive + secondLowestPositive;
            return sum;
        }
    }
}
