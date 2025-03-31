using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Thay đổi tên trường học trước khi tạo sinh viên
                Student.ChangeCollege("CODEGYM");

                // Tạo danh sách sinh viên và hiển thị thông tin
                Student[] students = new[]
                {
                    new Student(111, "Hoang"),
                    new Student(222, "Khanh"),
                    new Student(333, "Nam")
                };

                // Hiển thị thông tin tất cả sinh viên
                Console.WriteLine("Danh sach sinh vien:");
                foreach (var student in students)
                {
                    student.Display();
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
        }
    }

    public class Student
    {
        private readonly int _rollNo; // Mã số sinh viên, bất biến
        private readonly string _name; // Tên sinh viên, bất biến
        private static string _college = "BBDIT"; // Tên trường, mặc định là BBDIT

        // Thuộc tính public để truy cập _college từ bên ngoài
        public static string College => _college;

        // Constructor khởi tạo sinh viên với mã số và tên
        public Student(int rollNo, string name)
        {
            if (rollNo <= 0)
                throw new ArgumentException("Ma so sinh vien phai la so duong.");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ten khong duoc de trong.");

            _rollNo = rollNo;
            _name = name;
        }

        // Static method để thay đổi tên trường học
        public static void ChangeCollege(string newCollege)
        {
            if (string.IsNullOrWhiteSpace(newCollege))
                throw new ArgumentException("Ten truong khong duoc de trong.");

            _college = newCollege;
        }

        // Hiển thị thông tin sinh viên
        public void Display()
        {
            Console.WriteLine($"{_rollNo,-5} {_name,-10} {_college}");
        }
    }
}