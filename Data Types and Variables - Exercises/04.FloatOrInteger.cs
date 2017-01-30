using System;

namespace _4.FloatOrInteger
{
    public class FloatOrInteger
    {
        public static void Main(string[] args)
        {
            float number = float.Parse(Console.ReadLine());

            if (number % 10 == 0.0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
