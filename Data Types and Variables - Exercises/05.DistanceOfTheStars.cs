using System;

namespace _5.Distance_of_The_Stars
{
    class DistanceOfTheStars
    {

        static void Main(string[] args)
        {
            decimal nearestStarLy = 4.22m;
            decimal distanceToMilkyWayLy = 26000;
            decimal diameterOfMilkyWayLy = 100000;
            decimal distanceToTheEdgeOfUniverseLy = 46500000000;

            decimal oneLightYearInKm = 9450000000000;

            Console.WriteLine("{0:e2}", nearestStarLy*oneLightYearInKm);
            Console.WriteLine("{0:e2}", distanceToMilkyWayLy * oneLightYearInKm);
            Console.WriteLine("{0:e2}", diameterOfMilkyWayLy * oneLightYearInKm);
            Console.WriteLine("{0:e2}", distanceToTheEdgeOfUniverseLy * oneLightYearInKm);
        }
    }
}
