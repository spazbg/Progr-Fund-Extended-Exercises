using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers_Lab5
    //Read a list of decimal numbers and sort them in increasing order.
    //Print the output as shown in the examples below.
{
    class SortNumbers_Lab5
    {
        static void Main()
        {
            var input = Console.ReadLine();

            List<decimal> inputNums = new List<decimal>(input
                .Split(' ')
                .Select(decimal.Parse)
                .ToList()
                );

            inputNums.Sort();

            Console.Write(string.Join(" <= ", inputNums));
            Console.WriteLine();
        }
    }
}
