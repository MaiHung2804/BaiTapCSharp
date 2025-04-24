using System;

namespace demSoLanXuatHien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "lap trinh C# co ban";

            Console.Write("Nhap ky tu can dem: ");
            string input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                Console.Write("Nhap lai (khong de trong): ");
                input = Console.ReadLine();
            }

            char ch = input[0];
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }

            Console.WriteLine("Ky tu '" + ch + "' xuat hien " + count + " lan trong chuoi.");
        }
    }
}
