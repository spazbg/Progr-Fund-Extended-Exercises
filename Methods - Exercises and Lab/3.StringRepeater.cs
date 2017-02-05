using System;
namespace StringRepeater

//Write a RepeatString(str, count) method that 
//receives a string and an integer N as parameters 
//and returns the string, repeated N times.
//After that, print the result on the console.
{
   public class StringRepeater
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());

            string finalString = RepeatString(inputString, repeatNumber);
            Console.WriteLine(finalString);
        }

        static string RepeatString(string inputString, int repeatNumber)
        {
            string tempString = string.Empty;
            for (int i = 0; i < repeatNumber; i++)
            {
                tempString = tempString + inputString;
            }
            return tempString;
        }
    }
}
