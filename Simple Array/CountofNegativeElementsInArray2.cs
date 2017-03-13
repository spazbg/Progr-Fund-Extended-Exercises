using System;


namespace CountofNegativeElementsInArray2
//Read an integer N and on the next N lines read an array of integers. Then, 
//find the count of negative elements in the array.
{
    public class CountofNegativeElementsInArray2
    {
        public static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());

            var arrayOfNums = new int[numbers];

            int counter = 0;

            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                arrayOfNums[0] = int.Parse(Console.ReadLine());

                if (arrayOfNums[0]<0)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }
    }
}
