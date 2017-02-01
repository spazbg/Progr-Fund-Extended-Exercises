using System;

namespace _17.CypherRoulette
//You will be given an integer N. On the next N lines, you will receive some strings.
//The strings will be either:
//•	sequences of random characters
//•	or the command - "spin"

//If they are normal random characters, you should append them to one another in the cypher string.
//If the command "spin" is entered, every string entered after it should be appended at the start
//of the cypher string, if the command "spin" is entered again after that, you should again begin to append
//them at the end of the cypher string. And so, the append direction changes each time you enter the command "spin".
//If two equal strings are entered two consecutive times, the cypher resets - emptying the cypher string. This rule also applies to the "spin" command.
//Note: the "spin" commands do not count towards the N count.

//5
//Bed
//Is
//So
//Fine
//spin
//This

//ThisBedIsSoFine

//6
//How
//is
//is
//spin
//How
//spin
//_Are
//_You?

//How_Are_You?



{
    public class CypherRoulette
    {
        public static void Main(string[] args)
        {
            
            int numberInputs = int.Parse(Console.ReadLine());
            string newWord = string.Empty;
            string prevWord = string.Empty;
            string finalString = string.Empty;
            int appendDirection = 0;

            for (int i = 0; i < numberInputs; i++)
            {
                
                newWord = Console.ReadLine();
                                
                if (newWord == "spin") {
                    if (appendDirection == 0) {
                        appendDirection++;
                        numberInputs++;
                        
                        continue;
                    }
                    
                }
                if (newWord == "spin") {
                    if (appendDirection == 1)
                    {
                        appendDirection--;
                        numberInputs++;
                        
                        continue;
                    }
                    
                }

                if (i != 0)
                {
                    if (prevWord == newWord)
                    {
                        finalString = string.Empty;
                        continue;
                    }
                }

                if (appendDirection == 0)
                {
                    finalString = finalString + newWord;
                    prevWord = newWord;
                }

                if (appendDirection == 1)
                {
                    finalString = newWord + finalString;
                    prevWord = newWord;
                }
                
            }

            Console.WriteLine(finalString);
        }
    }
}
