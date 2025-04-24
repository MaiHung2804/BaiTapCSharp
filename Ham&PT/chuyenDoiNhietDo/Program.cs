using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuyenDoiNhietDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                ShowMenu();
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Fahrenheit: ");
                        if (double.TryParse(Console.ReadLine(), out fahrenheit))
                        {
                            Console.WriteLine("Fahrenheit to Celsius: " + Math.Round(FahrenheitToCelsius(fahrenheit), 2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out celsius))
                        {
                            Console.WriteLine("Celsius to Fahrenheit: " + Math.Round(CelsiusToFahrenheit(celsius), 2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Please choose 0, 1 or 2.");
                        break;
                }
            } while (choice != 0);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nMenu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (9.0 / 5) * celsius + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (5.0 / 9) * (fahrenheit - 32);
        }
    }
 }

