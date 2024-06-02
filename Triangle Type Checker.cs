using System;

namespace TriangleTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();


            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {

                if (IsValidTriangle(side1, side2, side3))
                {
                    string triangleType = GetTriangleType(side1, side2, side3);

                    Console.WriteLine($"The triangle is: {triangleType}");
                }
                else
                {
                    Console.WriteLine("The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter numerical values for the sides.");
            }
        }

        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        static string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
