using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing_Lab4
//  Read a text, split it into words and distribute them into 3 lists.
//	Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
//	Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
//	Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
//Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
//Print the 3 lists as shown in the example below.

{
    class SplitByWordCasing_Lab4
    {
        static void Main()
        {
            var input = Console.ReadLine();

            List<string> inputText = new List<string>(input
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList());

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string word in inputText)
            {
                int lowerSum = 0;
                int upperSum = 0;

                foreach (char letter in word)
                {
                    if (letter>= 'a' && letter <= 'z')
                    {
                        lowerSum++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        upperSum++;
                    }
                    else
                    {
                        lowerSum = 1;
                        upperSum = 1;
                    }
                }

                if (lowerSum == 0)
                {
                    upperCase.Add(word);
                }
                else if (upperSum ==0)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
