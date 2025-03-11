using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH5
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate = 23000f;
            Console.WriteLine("Nhap vao gia tri USD: ");
            float usd = float.Parse(Console.ReadLine());
            float vnd = usd * rate;
            Console.WriteLine(usd + " USD tuong ung " + vnd + " VND." );

        }
    }
}
