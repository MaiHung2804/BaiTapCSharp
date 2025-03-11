using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            float chieuCao;
            float chieuRong;
            float dienTich;
            Console.Write("Nhap chieu cao: ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieuRong = float.Parse(Console.ReadLine());
            dienTich = chieuRong * chieuCao;
            Console.WriteLine("Dien tich HCN la: " + dienTich);

        }
    }
}
