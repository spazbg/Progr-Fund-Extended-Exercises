using System;
using System.Linq;


namespace CountOccurrencesOfLargerNumbersInArray4
    //Read an array of real numbers and a number p.Find how many 
    //elements are bigger than p in the array and print the count
{
    public class CountOccurrencesOfLargerNumbersInArray4
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double smallestNum = double.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>smallestNum)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }
    }
}
