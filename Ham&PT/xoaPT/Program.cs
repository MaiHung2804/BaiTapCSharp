using System;

namespace xoaPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo và khởi tạo mảng
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phgan tu thu: " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Bước 2: Nhập X - phần tử cần xóa
            Console.Write("Nhap phan tu can xoa X = ");
            int x = int.Parse(Console.ReadLine());

            // Bước 3: Tìm vị trí phần tử X
            int index_del = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                {
                    index_del = i;
                    break;
                }
            }

            if (index_del == -1)
            {
                Console.WriteLine("Khong tim thay phan tu can xoa trong mang.");
            }
            else
            {
                // Bước 4: Xóa phần tử X
                for (int i = index_del; i < n - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                n--; // giảm kích thước mảng sau khi xóa

                // Bước 5: In ra mảng sau khi xóa
                Console.WriteLine("Mang sau khi xoa phan tu " + x + ":");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
