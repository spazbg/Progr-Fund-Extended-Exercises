using System;
using System.Collections.Generic;
using System.Linq;


namespace RemoveElementsAtOddPositions_1
    //Write a program which reads a list of space-separated strings and removes 
    //the elements at positions[1…3…5…7…etc.]. After that, print the elements 
    //with no delimiter. Note that positions are counted from 1.
{
    public class RemoveElementsAtOddPositions_1
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            List<string> words = new List<string> (inputString
                .Split(' ')
                .ToList()
                );

            List<string> oddWords = new List<string>();

            for (int i = 1; i < words.Count; i++)
            {
                if (!(i%2==0))
                {
                    oddWords.Add(words[i]);
                }
            }

            foreach (var item in oddWords)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
