using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendLists_Lab2
    //Write a program to append several lists of numbers.
	//Lists are separated by ‘|’.
	//Values are separated by spaces (‘ ’, one or several)
	//Order the lists from the last to the first, and their values from left to right.

{
    public class AppendLists_Lab2
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();

            List<string> result = new List<string>();

            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {
                var token = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                result.AddRange(token);

            }
            
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
