using System;
using System.Linq;


namespace EqualSequenceofElementsinArray6
//    Read an array of integers and find out if
//    all the elements in the array are the same.
{
    public class EqualSequenceofElementsinArray6
    {
        public static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool equalNumbers = true;
            var prevNumber = arrNumbers[0];

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (prevNumber == arrNumbers[i])
                {
                    prevNumber = arrNumbers[i];
                }

                else
                {
                    equalNumbers = false;
                    Console.WriteLine("No");
                    break;
                }

            }

            if (equalNumbers)
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
