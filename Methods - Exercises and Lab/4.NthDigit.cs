using System;

namespace NthDigit
//Write a method FindNthDigit(number, index) that receives a
//number and an index N as parameters and returns the Nth digit of the number
//(counted from right to left, starting from 1).
//After that, print the result on the console.
{
    public class NthDigit
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int indexNumb = int.Parse(Console.ReadLine());

            FindNthDigit(number, indexNumb);
        }

        static void FindNthDigit(long number, int indexNumb)
        {
            int count = 1;
            while (number >= 0)
            {
                if (count == indexNumb)
                {
                    long digit = number % 10;
                    Console.WriteLine(digit);
                    return;
                }
                number = number / 10;
                count++;
            }
        }
    }
}
