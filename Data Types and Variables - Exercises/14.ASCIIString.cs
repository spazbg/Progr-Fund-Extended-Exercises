using System;


namespace _14.ASCIIString
//Create a program that reads a number N. On the next N lines, it reads integers from the ASCII table.
//The task is to concatenate everything in string format.
{
    public class ASCIIString
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string asciiSymbols = "";
            for (int i = 0; i < number; i++)
            {
                int readAsciiNumber = int.Parse(Console.ReadLine());
                asciiSymbols = asciiSymbols + (char)readAsciiNumber;
               
            }
            Console.WriteLine(asciiSymbols);
        }
    }
}
