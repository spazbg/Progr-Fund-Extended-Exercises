using System;

namespace PrintingTriangleLab
{
    public class PrintingTriangleLab
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);

        }

        static void PrintingTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                PrintingLine(1, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                PrintingLine(1, i);
            }
        }

        static void PrintingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
