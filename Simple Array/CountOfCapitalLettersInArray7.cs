using System;
using System.Linq;

namespace CountOfCapitalLettersInArray7
//Read an array of strings and find out how many of them 
//are capital English letters(such as A, B, C etc.).
// Print the count on the console.

{
    public class CountOfCapitalLettersInArray7
    {
        public static void Main(string[] args)
        {
            string somewors = Console.ReadLine();

            var counter = 0;

            for (int i = 0; i < somewors.Length; i++)
            {
                if (somewors[i] >= 65 && somewors[i] <= 90)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
            
        }

    }
}
