using System;
using System.Linq;

namespace CountOfGivenElementInArray3
    //Read an array of integers and print how many times 
    //a given element exists in it.
{
    public class CountOfGivenElementInArray3
    {
        public static void Main(string[] args)
        {
            var arrNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int checkNumb = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] == checkNumb)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }
    }
}
