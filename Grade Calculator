using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Grade: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                char letterGrade;

                if (grade >= 90)
                {
                    letterGrade = 'A';
                }
                else if (grade >= 80)
                {
                    letterGrade = 'B';
                }
                else if (grade >= 70)
                {
                    letterGrade = 'C';
                }
                else if (grade >= 60)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }
                Console.WriteLine($"Letter Grading for {grade} is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Input must be between 0 and 100.");
            }
        
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a numerical value");
            }
        }   
    }
}
