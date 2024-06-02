using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int ticketPrice;

                if (age >= 65 || age <= 12)
                {
                    ticketPrice = 7;
                }
                else
                {
                    ticketPrice = 10;
                }

                Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Error: Invalid Input. Please enter a numerical value");
            }
        }
    }
}
