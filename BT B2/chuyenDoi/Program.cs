using System;

namespace chuyenDoi
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so can doc (0 - 999): ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Cach doc: " + DocSo(number));
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so hop le.");
            }
        }

        static string DocSo(int num)
        {
            if (num < 0 || num > 999)
                return "ngoai kha nang";

            string[] donVi = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin", "muoi", "muoi mot", "muoi hai", "muoi ba", "muoi bon", "muoi lam", "muoi sau", "muoi bay", "muoi tam", "muoi chin" };
            string[] chuc = { "", "", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };

            if (num < 20)
                return donVi[num];

            if (num < 100)
                return chuc[num / 10] + (num % 10 > 0 ? " " + donVi[num % 10] : "");

            return donVi[num / 100] + " tram" + (num % 100 > 0 ? " va " + DocSo(num % 100) : "");
        }
    }
}
