using System;
using System.Linq;


namespace CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArrayLab
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var curruntNumber = numbers[i];
                if (curruntNumber % 2 ==1 || curruntNumber % 2 == -1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
