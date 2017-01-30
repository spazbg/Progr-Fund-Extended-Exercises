using System;

namespace _6.IncrementVariable
{
    public class IncrementVariable
    {
        public static void Main(string[] args)
        {
            int byteNumber = int.Parse(Console.ReadLine());
            int maxByte = 256;

            if (byteNumber < maxByte)
            {
                Console.WriteLine(byteNumber);
            }
            else
            {
                Console.WriteLine(byteNumber % maxByte);
                Console.WriteLine("Overflowed {0} times", byteNumber/maxByte);
            }

        }
    }
}
