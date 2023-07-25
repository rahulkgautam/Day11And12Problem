using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class PatternProgram
    {
        public static void Pattern()
        {
            for (int i = 8; i >= 1; i--)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
