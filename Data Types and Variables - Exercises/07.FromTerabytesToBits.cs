using System;

namespace _7.FromTerabytesToBits
{
    public class FromTerabytesToBits
    {
        public static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());

            decimal bits = (decimal)terabytes * ((decimal)1024 * 1024 * 1024 * 1024 * 8);

            Console.WriteLine("{0:f0}", bits);
        }
    }
}
