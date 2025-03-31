using System;

namespace Animal
{
    // Đổi class thành abstract để biểu thị đây là một lớp cơ sở trừu tượng
    public abstract class Animal
    {
        // Chuyển Weight và Height từ string sang double để phù hợp với dữ liệu số
        public double Weight { get; }
        public double Height { get; }

        // Constructor với kiểm tra đầu vào cơ bản
        protected Animal(double weight, double height)
        {
            if (weight <= 0 || height <= 0)
                throw new ArgumentException("Weight and height must be positive values.");

            Weight = weight;
            Height = height;
        }

        // Phương thức trừu tượng để in thông tin
        public abstract void PrintInfo();
    }

    public class Cat : Animal
    {
        public string Name { get; }

        // Constructor kế thừa từ Animal và khởi tạo Name
        public Cat(double weight, double height, string name)
            : base(weight, height)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            Name = name;
        }

        // Ghi đè phương thức PrintInfo với string interpolation
        public override void PrintInfo()
        {
            Console.WriteLine($"Weight: {Weight}kg");
            Console.WriteLine($"Height: {Height}m");
            Console.WriteLine($"Name: {Name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tạo instance của Cat và gọi PrintInfo
                Cat cat = new Cat(20, 1.5, "kitty");
                cat.PrintInfo();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}