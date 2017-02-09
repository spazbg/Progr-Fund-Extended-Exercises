using System;

namespace MultiplyEvensbyOddsLab1

    //Create a program that reads an integer number and multiplies the sum
    //of all its even digits by the sum of all its odd digits:
{
    class MultiplyEvensbyOddsLab
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            long result = GetMultipleOfEvensAndOdds(Math.Abs(number));
            Console.WriteLine(result);
        }

        static long GetMultipleOfEvensAndOdds(long number)
        {
            long sumEvens = SumOfEvenDigits(number);
            long sumOdds = SumOfOddDigits(number);

            return (sumEvens * sumOdds);
        }

        static long SumOfOddDigits(long number)
        {
            long sumOdds = 0;
            while (number > 0)
            {
                long lastNumb = number % 10;
                if (lastNumb % 2 != 0)
                {
                    sumOdds += lastNumb;
                }

                number /= 10;
            }
            return sumOdds;
        }

        static long SumOfEvenDigits(long number)
        {
            long sumEven = 0;
            while (number > 0)
            {
                long lastNumb = number % 10;
                if (lastNumb % 2 == 0)
                {
                    sumEven += lastNumb;
                }

                number /= 10;
            }
            return sumEven;
        }
    }
}
