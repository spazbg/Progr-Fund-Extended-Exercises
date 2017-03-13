using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers_Lab3
    //Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
	//After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
	//Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).

{
    public class SumAdjacentEqualNumbers_Lab3
    {
        public static void Main()
        {
            List<double> numbers = new List<double>(Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList()
                );

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);

                    i = -1;
                }
            }

            Console.Write(string.Join(" ", numbers));
            Console.WriteLine();

        }
    }
}

