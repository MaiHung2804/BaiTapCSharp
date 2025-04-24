using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> characters = new List<char>();
            characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

            if (characters.Count > 6)
            {
                char value = characters[6];
                Console.WriteLine("Gia tri tai vi tri 6: " + value);
            }
            else
            {
                Console.WriteLine("Danh sach khong du phan tu de truy cap vi tri 6.");
            }
        }
    }
}
