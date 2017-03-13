using System;
using System.Linq;

namespace CharRotation_5
{
    public class CharRotation_5
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            
            var result = string.Empty;
            char charResult = ' ';
            for (int i = 0; i < firstInput.Length; i++)
            {
                if (secondInput[i]%2==0)
                {
                   charResult = (char)(firstInput[i] - secondInput[i]);

                }
                else
                {
                    charResult = (char)(firstInput[i] + secondInput[i]);
                }

                result = result + charResult;
            }
            Console.WriteLine(result);
        }
    }
}
