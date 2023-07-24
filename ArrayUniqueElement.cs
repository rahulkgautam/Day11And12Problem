using System;
using System.Collections.Generic;
using System.Text;

namespace Day11And12Problem
{
    class ArrayUniqueElement
    {
        public static void Unique()
        {
            int[] array = { 1, 2, 3, 4, 1, 2, 3, 4, 5, 6, 7, 8, 10, 20 };

            Console.WriteLine("Unique elements in the array:");

            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                // Check if the current element is unique
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                // If the current element is unique, print it
                if (isUnique)
                    Console.Write(array[i] + " ");
            }
        }
    }
}
