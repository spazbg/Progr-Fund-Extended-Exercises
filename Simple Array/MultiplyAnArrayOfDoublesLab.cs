using System;
using System.Linq;

namespace MultiplyAnArrayOfDoubles
{
    public class MultiplyAnArrayOfDoublesLab
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            var result = string.Join(" ", numbers);
            Console.WriteLine(result);

        }
    }
}
