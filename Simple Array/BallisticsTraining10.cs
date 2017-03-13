using System;
using System.Linq;


namespace BallisticsTraining10
{
    public class BallisticsTraining10
    {
        public static void Main(string[] args)
        {
            var target = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var targetX = target[0];
            var targetY = target[1];

            var commands = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var curruntX = 0;
            var curruntY = 0;


            for (int i = 0; i < commands.Length-1; i++)
            {
                if (i%2==0)
                {
                    if (commands[i] == "up")
                    {
                        curruntY = curruntY + int.Parse(commands[i + 1]);
                    }
                    if (commands[i] == "down")
                    {
                        curruntY = curruntY - int.Parse(commands[i + 1]);
                    }
                    if (commands[i] == "left")
                    {
                        curruntX = curruntX - int.Parse(commands[i + 1]);
                    }
                    if (commands[i] == "right")
                    {
                        curruntX = curruntX + int.Parse(commands[i + 1]);
                    }
                }
                
            }

            Console.WriteLine($"firing at [{curruntX}, {curruntY}]");
            if (targetX == curruntX && targetY == curruntY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
