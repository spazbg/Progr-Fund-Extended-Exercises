using System;

namespace _12.VariableInHexadecimalFormat
//Write a program that reads a number in hexadecimal format (0x##)
//convert it to decimal format and prints it.
{
    public class VariableInHexadecimalFormat
    {
        public static void Main(string[] args)
        {
            string hexInput = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexInput, 16));
        }
    }
}
