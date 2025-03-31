using System;

namespace HCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhap thong tin hinh chu nhat
                double chieuRong = NhapGiaTri("Nhap chieu rong: ");
                double chieuCao = NhapGiaTri("Nhap chieu cao: ");

                // Tao doi tuong hinh chu nhat
                Rectangle hinhChuNhat = new Rectangle(chieuRong, chieuCao);

                // Hien thi ket qua
                HienThiThongTinHinhChuNhat(hinhChuNhat);

            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Vui long nhap so hop le.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
        }

        // Phuong thuc nhap gia tri va kiem tra hop le
        private static double NhapGiaTri(string thongBao)
        {
            Console.Write(thongBao);
            string input = Console.ReadLine();

            // Kiem tra input co null hay khong
            if (string.IsNullOrEmpty(input))
            {
                throw new FormatException();
            }

            double giaTri = double.Parse(input);

            // Kiem tra gia tri co duong hay khong
            if (giaTri <= 0)
            {
                throw new ArgumentException("Gia tri phai lon hon 0.");
            }

            return giaTri;
        }

        // Phuong thuc hien thi thong tin hinh chu nhat
        private static void HienThiThongTinHinhChuNhat(Rectangle hinh)
        {
            Console.WriteLine("\nHinh chu nhat cua ban: " + hinh.ToString());
            Console.WriteLine("Chu vi: " + hinh.TinhChuVi().ToString("F2"));
            Console.WriteLine("Dien tich: " + hinh.TinhDienTich().ToString("F2"));
        }
    }

    public class Rectangle
    {
        private readonly double chieuRong;
        private readonly double chieuCao;

        // Constructor khoi tao hinh chu nhat voi chieu rong va chieu cao
        public Rectangle(double rong, double cao)
        {
            chieuRong = rong;
            chieuCao = cao;
        }

        // Tinh dien tich hinh chu nhat
        public double TinhDienTich()
        {
            double dienTich = chieuRong * chieuCao;
            return dienTich;
        }

        // Tinh chu vi hinh chu nhat
        public double TinhChuVi()
        {
            double chuVi = 2 * (chieuRong + chieuCao);
            return chuVi;
        }

        // Hien thi thong tin hinh chu nhat duoi dang chuoi
        public override string ToString()
        {
            string thongTin = "{rong=" + chieuRong.ToString("F2") +
                            ", cao=" + chieuCao.ToString("F2") + "}";
            return thongTin;
        }
    }
}