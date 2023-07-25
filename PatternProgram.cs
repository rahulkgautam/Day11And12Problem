using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class PatternProgram
    {
        public static void Pattern()
        {
            int length = 7, width = 7;
            Console.Write(" ");

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n ");
            }
         }
    }
}
