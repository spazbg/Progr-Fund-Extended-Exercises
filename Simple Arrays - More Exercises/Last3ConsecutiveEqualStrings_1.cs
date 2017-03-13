using System;
using System.Linq;


namespace Last3ConsecutiveEqualStrings_1
    //Read an array of strings and find the last three consecutive equal strings.
{
    public class Last3ConsecutiveEqualStrings_1
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ');

            var counter = 1;
            var theWord = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (i>0 && words[i] == words[i-1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter ==3)
                {
                    theWord = words[i];
                }
            }
            Console.WriteLine(theWord+" "+ theWord+" "+ theWord);
        }

    }
}
