using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            if ( (nam % 4 == 0 && nam % 100 != 0) || ( nam % 400 != 0))
            {
                Console.WriteLine($"{nam} la nam nhuan");
            }
            else
            {
                Console.WriteLine($"{nam} khong phai la nam nhuan");
            }

        }
    }
}
