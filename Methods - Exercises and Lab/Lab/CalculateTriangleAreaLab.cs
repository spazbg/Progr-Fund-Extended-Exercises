using System;

namespace CalculateTriangleArea
//Create a method that calculates
//and returns the area of a triangle by given base and height
{
    public class CalculateTriangleAreaLab
    {
        public static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHigh = double.Parse(Console.ReadLine());

            double resultArea = triangleArea(triangleBase, triangleHigh);
            Console.WriteLine(resultArea);
        }

        static double triangleArea(double width, double high)
        {
            double area = (width * high) / 2;
            return area;
        }
    }
}
