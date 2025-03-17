using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        for (int i = 6; i > 0; i--)
                        {
                            Console.WriteLine(new string('*', i));
                        }
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}
