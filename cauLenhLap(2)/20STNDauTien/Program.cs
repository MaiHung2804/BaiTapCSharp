using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20STNDauTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = Int32.Parse(Console.ReadLine());
            int count = 0;
            int N = 2;
            while (count < num)
            {
                if (IsPrime(N))
                {
                    Console.WriteLine(N + " ");
                    count++;
                }
                N++;
            }
        }
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
