using System;
using System.Linq;

namespace IncreasingSequenceofElements5
    //Read an array of integers and find out if it is an increasing sequence.
    //Print Yes if it does and No if it doesn’t.
{
    public class IncreasingSequenceofElements5
    {
        public static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var previusNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>previusNumber)
                {
                    previusNumber = array[i];
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }
            }

            if (previusNumber == array[array.Length-1])
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
