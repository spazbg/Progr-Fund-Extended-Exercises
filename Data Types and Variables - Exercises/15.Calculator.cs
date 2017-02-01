using System;

namespace _15.Calculator
//Create a program that reads 3 lines:
//An operand.
//An operator.
//A second operand.
//And performs the operation between the operands.
//The left and right operands will always be integers.

{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");

        }
    }
}
