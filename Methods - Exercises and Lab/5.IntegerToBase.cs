using System;

namespace IntegerToBase
{
    public class IntegerToBase
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var finalNumb = IntegrToBase(number, toBase);
            Console.WriteLine(finalNumb);
        }

        static string IntegrToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
