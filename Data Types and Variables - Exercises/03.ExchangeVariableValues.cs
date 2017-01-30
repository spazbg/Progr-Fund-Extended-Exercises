using System;

namespace _03.ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            int firstVariable = int.Parse(Console.ReadLine());
            int secondVariable = int.Parse(Console.ReadLine());

            int tempVariable;

            tempVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = tempVariable;

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
        }
    }
}
