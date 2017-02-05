using System;
namespace StringEncryption
//    Write a method Encrypt(char letter) which encrypts the letter in the following way:
//•	Take the first and the last digit of its ASCII code and append them together in a string.
//•	Append at the start of the resulting string the character corresponding to:
//o the ASCII code of the letter + the last digit of the ASCII code of the letter
//•	Then append at the end of the resulting string the character corresponding to:
//o the ASCII code of the letter - the first digit of the ASCII code of the letter
//•	The method should return the encrypted string.
//Example
//•	j -> p16i
//o   j’s ASCII code is 106  First digit – 1, last digit – 6
//o Append the first and last digit  16
//o Append the character, resulting from the ASCII code + last digit to the start  106 + 6  112  p
//o   Append the character, resulting from the ASCII code - first digit to the end  106 - 1  105  i
//o   End result  p16i
//Assume that the input for this method will always be valid.
//The main program should read an input from the user - an integer N.
//On the next N lines, you will receive characters. Encrypt them and append them to an encrypted string.
//In the end, what you should have is a long encrypted string of characters like this:
//•	S, o, f, t, U, n, i  V83Kp11nh12ez16sZ85Mn10mn15h
//Your task is to print the encrypted string.

{
    public class StringEncryption
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var encrypted = Encrypted(currentChar);

                result += encrypted;
            }

            Console.WriteLine(result);
        }

        static string Encrypted(char currentChar)
        {
            var asciiCode = (int)currentChar;

            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = GetLastDigit(asciiCode);
            
            var firstSymbol = (char)(asciiCode + lastDigit);
            var lastSymbol = (char)(asciiCode - firstDigit);

            var result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";

            return result;
        }

        static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }

        static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            return firstDigit;
        }
    }
}
