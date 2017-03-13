using System;

using System.Linq;


namespace RotateArrayOfStringsLab
{
    public class RotateArrayOfStringsLab
    {
        public static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(' ');

            string[] secondString = new string[strings.Length];

            secondString[0] = strings[strings.Length - 1];

            for (int i = 0; i < strings.Length-1; i++)
            {
                secondString[i+1] = strings[i];
            }

            var resultToString = string.Join(" ", secondString);
            Console.WriteLine(resultToString);
        }
    }
}
