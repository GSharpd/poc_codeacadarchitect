using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
          double rectangleArea = Rect(2500, 1500);
          double circleArea = Circle(375) / 2;
          double triangleArea = Triangle(750, 500);
          double totalArea = rectangleArea + circleArea + triangleArea;
          Console.WriteLine(totalArea);
          double matCost = totalArea * 180;
          //double matCostRounded = Math.Round(matCost, 2); longer method, easier to do inside the interpolation
          Console.WriteLine($"The total area is {totalArea} and the total material cost is {Math.Round(matCost, 2)} pesos!");
            
        }            
            
            static double Rect(double length, double width)
            {
                return length * width;
            }

            static double Circle(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }

            static double Triangle(double bottom, double height)
            {
                return 0.5 * bottom * height;
            }
    }
}
