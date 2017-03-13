using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper_6
//You will be given two lists of integers on the first and second line of the input respectively(space-separated). We want to zip these two lists together like a zipper, but one or several of the elements in either of the lists are too large to allow that to happen.Being larger, they have more digits than the element with the smallest amount of digits in the two lists.
//Your task is to find any elements which have more digits than the element with the least amount of digits in the list (if such exist) and remove them, then zip the lists together as shown in the example.
//After you stack the lists, print the resulting list on the console (one line, space-separated).

{
    public class StuckZipper_6
    {
        public static void Main()
        {
            var list1 = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            var list2 = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            var idealNumberOfDigits = CalclateidealNumberOfDigits(list1, list2);
            RemoveElementsWithNonidealNumberOfDigitsFromList(list1, idealNumberOfDigits);
            RemoveElementsWithNonidealNumberOfDigitsFromList(list2, idealNumberOfDigits);

            var insertionIndex = 1;
            for (int i = 0; i < list1.Count; i++)
            {
                var currentElement = list1[i];
                list2.Insert(Math.Min(insertionIndex, list2.Count), currentElement);
                insertionIndex = insertionIndex + 2;
            }

            Console.WriteLine(string.Join(" ", list2));

        }

        static void RemoveElementsWithNonidealNumberOfDigitsFromList(List<int> list, int idealNumberOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumberOfDigits = CalculateNumberOfDigits(list[i]);
                if (currentNumberOfDigits > idealNumberOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
          
        }

        static int CalclateidealNumberOfDigits(List<int> list1, List<int> list2)
        {
            var idealNumberOfDigits = int.MaxValue;
            foreach (var item in list1)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }
            foreach (var item in list2)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            return idealNumberOfDigits;
        }

        static int CalculateNumberOfDigits(int number)
        {
            number = Math.Abs(number);

            var numberOfDigits = number.ToString().Length;
            return numberOfDigits;
        }
    }
}
