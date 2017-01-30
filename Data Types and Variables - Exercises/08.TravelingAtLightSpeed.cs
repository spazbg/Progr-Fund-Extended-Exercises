using System;

namespace _8.TravelingAtLightSpeed
{
    public class TravelingAtLightSpeed
    {
        public static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lyInKm = 9450000000000m;
            decimal speedOfLight = 300000m;

            decimal totalTimeInSec = (lyInKm / speedOfLight) * lightYears;

            TimeSpan t = TimeSpan.FromSeconds((double)totalTimeInSec);

            string finalFormattedTime = string.Format(
                  "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                  t.Days / 7,
                  t.Days % 7,
                  t.Hours,
                  t.Minutes,
                  t.Seconds);

            Console.WriteLine(finalFormattedTime);

        }
    }
}
