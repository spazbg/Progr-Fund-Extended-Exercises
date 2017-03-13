using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers_Lab7
//Read a list of integers in range[0…1000] and print them in
//ascending order along with their number of occurrences.
{
    class CountNumbers_Lab7
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> nums = new List<int>(input
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                );

            nums.Sort();
            var counter = 1;

            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    counter++;
                }
                else
                {
                    Console.Write($"{nums[i]} -> {counter}");
                    Console.WriteLine();
                    counter = 1;
                }
            }

            Console.Write($"{nums[nums.Count - 1]} -> {counter}");
            Console.WriteLine();

        }
    }
}
