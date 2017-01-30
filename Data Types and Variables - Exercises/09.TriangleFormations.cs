using System;

namespace _9.TriangleFormations
//You are given 3 integer numbers: a, b and c, which will represent the 3 sides of a triangle. Your task is to check whether the triangle is valid.
//If it is, print "Triangle is valid.".
//Otherwise print "Invalid Triangle." and end the program.
//If it is valid, you have to check if it is a right triangle (a2 + b2 == c2).
//If it is a right triangle, print "Triangle has a right angle between sides a and b", depending on which side forms a right angle.If the sides b and c form a right angle, print "Triangle has a right angle between sides b and c", and so on.

{
    public class TriangleFormations
    {
        public static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA + sideB > sideC &&
                sideB + sideC > sideA &&
                sideC + sideA > sideB )
            {
                Console.WriteLine("Triangle is valid.");
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideB * sideB + sideC * sideC == sideA * sideA)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (sideC * sideC + sideA * sideA == sideB * sideB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }


        }
    }
}
