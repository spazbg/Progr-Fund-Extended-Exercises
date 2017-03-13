using System;
using System.Collections.Generic;
using System.Linq;


namespace SquareNumbers_Lab6
    //Read a list of integers and extract all square numbers from it and print them in descending order.A square number is an integer which is the square of any integer.
    //For example, 1, 4, 9, 16 are square numbers.
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<int> inputNums = new List<int>(input
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                );

            List<int> result = new List<int>();

            foreach (var num in inputNums)
            {
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    result.Add(num);
                }
            }

            result.Sort();
            result.Reverse();

            Console.Write(string.Join(" ", result));
            Console.WriteLine();
        }
    }
}
