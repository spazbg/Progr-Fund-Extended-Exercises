using System;
namespace MinMethod
{
    public class MinMethod
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int minNumber = GetMin(GetMin(a, b), GetMin(b, c));
            Console.WriteLine(minNumber);
        }

        static int GetMin(int firstNumber, int secondNumber)
        {
            if (firstNumber<= secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }
    }
}
