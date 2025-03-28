using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ma tran tu nguoi dung:");
            int[,] maTranNguoiDung = LayMaTranTuNguoiDung();
            TinhVaHienThiTongDuongCheo(maTranNguoiDung);
        }

        static void TinhVaHienThiTongDuongCheo(int[,] maTran)
        {
            int kichThuoc = maTran.GetLength(0);
            int tong = 0;

            for (int i = 0; i < kichThuoc; i++)
            {
                tong += maTran[i, i];
            }

            Console.WriteLine($"Tong cac phan tu tren duong cheo chinh: {tong}");
            HienThiMaTran(maTran);
        }

        static int[,] LayMaTranTuNguoiDung()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            int kichThuoc = int.Parse(Console.ReadLine());
            int[,] maTran = new int[kichThuoc, kichThuoc];

            for (int i = 0; i < kichThuoc; i++)
            {
                for (int j = 0; j < kichThuoc; j++)
                {
                    Console.Write($"Nhap phan tu [{i}, {j}]: ");
                    maTran[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return maTran;
        }

        static void HienThiMaTran(int[,] maTran)
        {
            int kichThuoc = maTran.GetLength(0);
            Console.WriteLine("Ma tran:");

            for (int i = 0; i < kichThuoc; i++)
            {
                for (int j = 0; j < kichThuoc; j++)
                {
                    Console.Write($"{maTran[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}