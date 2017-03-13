using System;
namespace SumArrayElementsLab
{
    public class SumArrayElementsLab
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            var totalSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                var curruntNum = numbers[i];
                totalSum += curruntNum;
            }

            Console.WriteLine(totalSum);
        }
    }
}
