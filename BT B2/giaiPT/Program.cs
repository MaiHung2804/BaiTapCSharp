using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("PT co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("PT vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Nghiem cua PT la x = {x}");
            }
        }
    }
}
