using System;
using System.Linq;

namespace SmallestElementInArray
{
    class SmallestElementInArrayLab
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
