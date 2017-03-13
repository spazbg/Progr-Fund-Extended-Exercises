using System;
using System.Linq;

namespace ArraySymmetry8
    //Read an array of strings and find out if it’s symmetric.
    //If it is, print “Yes”, otherwise print “No”.
{
    public class ArraySymmetry8
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            bool symmetric = true;

            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    Console.WriteLine("No");
                    symmetric = false;
                    break;
                }
                              
            }
            if (symmetric)
            {
                Console.WriteLine("Yes");
            }
   
            
        }
    }
}
