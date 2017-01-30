using System;

namespace _10.DataOverflow
{
    //You will be given two numbers. Your task is to find the lowest one by value, 
    //find the numerical type it fits in from the following (byte, ushort, uint, ulong) 
    //and check how many times the greater one by value overflows the type of the smaller
    //one (rounded to the nearest whole integer).

    public class DataOverflow
    {
        public static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            var biggerNumber = Math.Max(firstNumber, secondNumber);
            var smallerNumber = Math.Min(firstNumber, secondNumber);

            //Console.WriteLine(smallerNumber +" "+ biggerNumber);

            string smallerNumType;
            var maxValueType = 0.0;

            if ((biggerNumber <= byte.MaxValue))
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (biggerNumber <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (biggerNumber <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
            }
            else
            {
                Console.WriteLine("bigger type: ulong");
            }

            if (smallerNumber <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                smallerNumType = "byte";
                maxValueType = byte.MaxValue;
            }
            else if (smallerNumber <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                smallerNumType = "ushort";
                maxValueType = ushort.MaxValue;
            }
            else if (smallerNumber <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                smallerNumType = "uint";
                maxValueType = uint.MaxValue;
            }
            else
            {
                Console.WriteLine("smaller type: ulong");
                smallerNumType = "ulong";
                maxValueType = ulong.MaxValue;
            }

            Console.WriteLine("{0} can overflow {1} {2} times", biggerNumber, smallerNumType, Math.Round((double)biggerNumber/maxValueType));

        }
    }
}
