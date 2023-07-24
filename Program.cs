using System;
using System.Collections.Generic;

namespace Day11And12Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 1, 3, 2, 4, 4, 5, 1 };
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Count the frequency of each element
            foreach (int element in arr)
            {
                if (frequencyMap.ContainsKey(element))
                {
                    frequencyMap[element]++;
                }
                else
                {
                    frequencyMap[element] = 1;
                }
            }

            // Display the result
            Console.WriteLine("Element\tFrequency");
            foreach (var pair in frequencyMap)
            {
                Console.WriteLine($"{pair.Key}\t{pair.Value}");
            }
        }
    }
    
    
}
