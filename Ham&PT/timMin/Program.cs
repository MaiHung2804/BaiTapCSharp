using System;

namespace timMin
{
    internal class Program
    {
        // Phương thức tìm vị trí phần tử nhỏ nhất trong mảng
        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }

        // Hàm Main - điểm bắt đầu chương trình
        public static void Main(string[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int index = MinValue(arr);

            Console.WriteLine("The smallest element in the array is: " + arr[index]);
            Console.WriteLine("Its position (index) is: " + index);
        }
    }
}
