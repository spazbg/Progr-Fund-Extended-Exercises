using System;
namespace GreaterОfTwoValuesLab
//You are given two values of the same type as input.
//the values can be of type int, char of string. create a method
//GetMax() that returns the greater of the two values:
{
   public class GreaterОfTwoValuesLab
    {
        public static void Main(string[] args)
        {
            string typeInput = Console.ReadLine();
            if (typeInput == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                int max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
            else if (typeInput == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                char max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
            else
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                string max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
