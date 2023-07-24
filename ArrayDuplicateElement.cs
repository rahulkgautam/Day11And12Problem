using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class ArrayDuplicateElement
    {
        public static void Duplicate()
        {
            int[] array = { 1, 2, 3, 4, 20, 2, 3, 20, 5, 6, 7, 8, 10, 10 };
            int duplicateCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicateCount++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements in the array: " + duplicateCount);
        }
    }
}
