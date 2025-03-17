using System;

namespace kiemTraSNT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = num >= 2;
            for (int i = 2; i * i <= num && isPrime; i++)
            {
                isPrime = num % i != 0;
            }

            Console.WriteLine(num + (isPrime ? " la" : " khong phai") + " so nguyen to");
            Console.ReadLine();
        }
    }
}