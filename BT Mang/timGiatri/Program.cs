using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timGiatri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Hung", "Son", "Ha", "Thuy", "Long", "Mai", "Tien" };
            Console.WriteLine("Enter a name's student: ");
            string input_name = Console.ReadLine();
            int index = Array.IndexOf(students, input_name);
            if (index != -1)
            {
                Console.WriteLine($"Position of the student '{input_name}' in the list is: {index +1}");
            }
            else
            {
                Console.WriteLine($"Not Found '{input_name}' in the list");
            }
        }
    }
}
