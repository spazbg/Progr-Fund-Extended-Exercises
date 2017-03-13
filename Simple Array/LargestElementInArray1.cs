using System;

namespace LargestElementInArray1
//Read an integer N and on the next N lines read an array of integers.
//Then, find its largest element.
{
    public class LargestElementInArray1
    {
        public static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            int[] numArray = new int[numbers];
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
                if (numArray[i]>maxNumber)
                {
                    maxNumber = numArray[i];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
