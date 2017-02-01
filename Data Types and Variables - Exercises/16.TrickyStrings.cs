using System;

namespace _16.TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberN = int.Parse(Console.ReadLine());
            string lastPartOfString = "";

            string finalString = "";

            for (int i = 0; i < numberN; i++)
            {
               if (i == numberN-1)
                {
                    lastPartOfString = Console.ReadLine();
                    break;
                }
                
                string newString = Console.ReadLine();
                finalString = finalString + (newString + delimiter);
          
            }
            
            Console.WriteLine(finalString + lastPartOfString);
        }
    }
}
