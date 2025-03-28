using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timMax2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("\nNhap ma tran tu nguoi dung:");
            float[,] maTranNguoiDung = LayMaTranTuNguoiDung();
            TimVaHienThiMax(maTranNguoiDung);
        }

        static void TimVaHienThiMax(float[,] maTran)
        {
            int hang = maTran.GetLength(0);
            int cot = maTran.GetLength(1);

            float giaTriMax = maTran[0, 0];
            int hangMax = 0;
            int cotMax = 0;

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    if (maTran[i, j] > giaTriMax)
                    {
                        giaTriMax = maTran[i, j];
                        hangMax = i;
                        cotMax = j;
                    }
                }
            }

            Console.WriteLine($"Gia tri lon nhat: {giaTriMax}");
            Console.WriteLine($"Toa do: [{hangMax}, {cotMax}]");
            HienThiMaTran(maTran);
        }

        static float[,] LayMaTranTuNguoiDung()
        {
            Console.Write("Nhap so hang: ");
            int hang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cot = int.Parse(Console.ReadLine());

            float[,] maTran = new float[hang, cot];

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"Nhap phan tu [{i}, {j}]: ");
                    maTran[i, j] = float.Parse(Console.ReadLine());
                }
            }

            return maTran;
        }

        static void HienThiMaTran(float[,] maTran)
        {
            int hang = maTran.GetLength(0);
            int cot = maTran.GetLength(1);

            Console.WriteLine("Ma tran:");
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"{maTran[i, j],6:F1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
