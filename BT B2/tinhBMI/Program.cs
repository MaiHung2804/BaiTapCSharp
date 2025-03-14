using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can nang(kg): ");
            double canNang = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao(m): ");
            double chieuCao = double.Parse(Console.ReadLine());
            double BMI = canNang / ( chieuCao * chieuCao );
            Console.WriteLine($"Chi so BMI cua ban: {BMI:F2}");
            if (BMI < 18.5)
            {
                Console.WriteLine("Ban dang thieu can");
            }
            else if(BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Ban co can nang binh thuong");
            }
            else if(BMI >=25 && BMI < 29.9)
            {
                Console.WriteLine("Ban dang bi thua can");
            }
            else
            {
                Console.WriteLine("Ban bi beo phi");
            }
        }
    }
}
