using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSumAfterExtraction_3
{
    public class EqualSumAfterExtraction_3
    {
        public static void Main()
        {
            var firstList = new List<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()                
                );

            var secondList = new List<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                );

            for (int i = 0; i < firstList.Count; i++)
            {
                while (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            var sumFirstList=0;
            var sumSecondList = 0;

            foreach (var numb in firstList)
            {
                sumFirstList += numb;
            }
            foreach (var numb in secondList)
            {
                sumSecondList += numb;
            }

            if (sumFirstList.Equals(sumSecondList))
            {
                Console.WriteLine("Yes. Sum: {0}", sumFirstList);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirstList-sumSecondList));
            }
        }
    }
}
