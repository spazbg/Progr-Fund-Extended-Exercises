using System;
using System.Linq;


namespace Altitude9
//    You are an airplane pilot, trying to maneuver your airplane to safety from an unknown danger.
//An array holds a sequence of up / down commands and numbers. Its first element always holds the initial altitude. The command up increases the altitude by the next number, while the command down decreases the altitude by the next number.
//If at any point the altitude becomes either zero or negative, print “crashed” and end the program. If by the end, the altitude is positive, however, print “got through safely.current altitude: { altitude}
//m”.

{
    public class Altitude9
    {
        public static void Main(string[] args)
        {
            var altitude = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var increase = true;
            var startAltitude = double.Parse(altitude[0]);
            if (startAltitude <= 0)
            {
                Console.WriteLine("crashed");

            }

            else
            {
                bool crash = false;
                
                var currentAltitude = startAltitude;
                for (int i = 1; i <= altitude.Length - 1; i++)
                {

                    if (i % 2 != 0)
                    {
                        if (altitude[i] == "up")
                        {
                            increase = true;
                        }

                        if (altitude[i] == "down")
                        {
                            increase = false;
                        }

                    }

                    if (i % 2 == 0 && increase == true)
                    {
                        currentAltitude = currentAltitude + double.Parse(altitude[i]);
                        if (currentAltitude <= 0)
                        {
                            Console.WriteLine("crashed");
                            crash = true;
                            break;
                        }

                    }

                    if (i % 2 == 0 && increase == false)
                    {
                        currentAltitude = currentAltitude - double.Parse(altitude[i]);
                        if (currentAltitude <= 0)
                        {
                            Console.WriteLine("crashed");
                            crash = true;
                            break;
                        }

                    }
                    
                }

                if (currentAltitude > 0)

                {
                    Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
                }
               
            }
                        
        }
    }
}
