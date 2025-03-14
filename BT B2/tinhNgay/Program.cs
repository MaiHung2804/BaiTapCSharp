using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhNgay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12){
                Console.WriteLine($"Thang {thang} co 31 ngay.");
            }
            else if (thang == 2)
            {
                Console.WriteLine($"Thang {thang} co 28 hoac 29 ngay");
            }
            else
            {
                Console.WriteLine($"Thang {thang} co 30 ngay ");
            }
        }
    }
}
