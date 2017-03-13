using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf_5
//You will receive a list of integers on the first input line(space-separated). 
//Your task is to separate the list into two parts and perform the following operations:
//      Input                 
//11 22 33 45 14 12	
//      Output
//4 11 5 1 22 4 1 33 2

{
    public class TearListInHalf_5
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var inputString = new List<int>(input
                .Split()
                .Select(int.Parse)
                .ToList()
                );

            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i < inputString.Count / 2; i++)
            {
                list2.Add(inputString[i]);

            }

            for (int i = inputString.Count / 2; i < inputString.Count; i++)
            {
                list1.Add(inputString[i]);

            }

            var result = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i] / 10);
                result.Add(list2[i]);
                result.Add(list1[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
