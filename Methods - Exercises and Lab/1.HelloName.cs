using System;

namespace HelloName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
