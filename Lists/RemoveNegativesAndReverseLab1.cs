using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverseLab1
    //Read a list of integers, remove all negative numbers from it and print the 
    //remaining elements in reversed order.
    //In case of no elements left in the list, print “empty”.
{
    public class RemoveNegativesAndReverseLab1
    {
        public static void Main()
        {
            List<int> listOfNumbs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> nonNegative = new List<int>();

            foreach (var numb in listOfNumbs)
            {
                if (numb > 0)
                {
                    nonNegative.Add(numb);
                }
            }

            nonNegative.Reverse();

            if (nonNegative.Count>0)
            {
                foreach (var positiveNumb in nonNegative)
                {
                    Console.Write(positiveNumb + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("empty");
            }
           
        }
    }
}
