using System;
namespace DrawAFilledSquareLab
{
    public class DrawAFilledSquareLab
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }

        static void PrintSquare(int n)
        {
            PrintTopAndBottomRow(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            
            PrintTopAndBottomRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintTopAndBottomRow(int n)
        {
            Console.Write(new string('-', 2 * n));
            Console.WriteLine();
        }

       
    }
}
