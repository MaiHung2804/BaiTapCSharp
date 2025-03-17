using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vayLai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            Console.WriteLine("Nhap so tien: ");
            money = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thang gui: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so % lai suat: ");
            intersetRate = double.Parse(Console.ReadLine());

            double totalInterset = 0.0;
            for (int i=0; i<month; i++)
            {
                totalInterset += money * (intersetRate/100) / 12 ;
            }
            Console.WriteLine($"Tong so tien nhan:{totalInterset:F2} ");
        }
    }
}
