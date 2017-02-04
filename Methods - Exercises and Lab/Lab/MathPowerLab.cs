using System;

namespace Math_Power
//Create a method that calculates and returns
//the value of a number raised to a given power:
{
    class MathPowerLab
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RasieToPower(number, power);
            Console.WriteLine(result);
        }

        static double RasieToPower(double number, int power)
        {
            double temp = 1;
            for (int i = 0; i < power; i++)
            {
                temp = temp * number;
            }
            return temp;
        }
    }
}
