using System;

namespace Phonebook_3
//You will be given an array of phone numbers(strings) and an array of names(strings). After which, you will be given
//strings on new lines, until you receive the command “done”. Find the numbers, which correspond to the names
//and print them on the console in the following format:
//{name} -> {number}
//A number corresponds to a name when it’s located on the same position as its corresponding name in both arrays.

{
    public class Phonebook_3
    {
        public static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            var findName = string.Empty;

            while (findName != "done")
            {
                findName = Console.ReadLine();
                Phonebook(names, phoneNumbers, findName);
            }

        }

        static void Phonebook(string[] names, string[] phoneNumbers, string findName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (findName == names[i])
                {
                    Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    return;

                }
            }
        }
    }
}
