using System;
using System.Linq;

namespace Phone_4
{
    public class Phone_4
    {
        public static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            var command = Console.ReadLine();

            while (command != "done")
            {
                
                var commandArr = command.Split(' ');
                phone(names, phoneNumbers, commandArr[0], commandArr[1]);

                command = Console.ReadLine();
            }

        }

        static void phone(string[] names, string[] phoneNumbers, string command, string target)
        {
            if (command == "call")
            {
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (phoneNumbers[i] == target)
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        callStatus(phoneNumbers[i]);
                    }
                    else if (names[i] == target)
                    {
                        Console.WriteLine($"calling {phoneNumbers[i]}...");
                        callStatus(phoneNumbers[i]);
                    }

                    
                }
            }
            if (command == "message")
            {
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (phoneNumbers[i] == target)
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        smsStatus(phoneNumbers[i]);
                    }
                    else if (names[i] == target)
                    {
                        Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        smsStatus(phoneNumbers[i]);
                    }
                }
            }
        }

        static void smsStatus(string number)
        {
            var onlyDigitNumb = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 47 && number[i] < 58)
                {
                    onlyDigitNumb = onlyDigitNumb + number[i];
                }
            }

            int sum = 0;

            for (int i = 0; i < onlyDigitNumb.Length; i++)
            {

                sum = sum - (onlyDigitNumb[i] - 48); // СЪБИРАМ СТОЙНОСТА НА ЧАРОВЕТЕ???
            }

            if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        static void callStatus(string number)
        {
            var onlyDigitNumb = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]>47 && number[i]<58)
                {
                    onlyDigitNumb = onlyDigitNumb + number[i];
                }
            }

            int sum = 0;

            for (int i = 0; i < onlyDigitNumb.Length; i++)
            {

                sum = sum + (onlyDigitNumb[i] - 48) ; // ВАДИМ СТОЙНОСТА НА ЧАРОВЕТЕ???
            }

            if (sum%2!=0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                var mins = sum / 60;
                var sec = sum % 60;
                Console.WriteLine($"call ended. duration: {mins:0#}:{sec:0#}");
            }

        }
    }
}
