using System;
namespace Notification
//    Write 2 methods:
//static string ShowSuccess(string operation, string message)
//{
//    …
//}
//which prints a message in the following format:
//Successfully executed { operation }.
//==============================
//Message: {message
//}.
//and
//static string ShowError(string operation, int code)
//{
//    …
//}
//which prints a message in the following format:
//Error: Failed to execute {operation}.
//==============================
//Error Code: {code}.
//Reason: {reason}.
//The reason is determined by the code:
//•	If the code is positive, the reason is "Invalid Client Data"
//•	If the code is negative, the reason is "Internal System Failure"
//Then, create a program which accepts an integer N.
//On the next N lines, the user receives a result – "success" or "error". If the current operation is success, it should prompt the user for an operation and a message.If the operation is error, it should prompt the user for an operation and a code.
//If neither "success", nor "error" is given, nothing should be printed and the program should continue.

{
    public class Notification
    {
        public static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string result = Console.ReadLine();
                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    ShowSuccess(operation, message);
                }

                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }

            }  

        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            var reason = string.Empty;

            if (code > 0)
            {
                reason = "Invalid Client Data";
            }

            if (code < 0)
            {
                reason = "Internal System Failure";

            }

            Console.WriteLine($@"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }

    }

}
