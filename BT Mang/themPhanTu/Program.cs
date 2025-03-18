using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace themPhanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elemwnts: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] arr = new int[N];

            Console.WriteLine("Enter the elements of the array: ");
            for(int i=0; i<N; i++)
            {
                Console.WriteLine($"Element{i + 1}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the munber insert");
            int X = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position to insert: ");
            int Index = Int32.Parse(Console.ReadLine());

            if (Index < 0 || Index > arr.Length)
            {
                Console.WriteLine("Cannot insert element into the array. Index is out of range.");
                return;
            }

            int[] newArray = new int[arr.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < Index)
                {
                    newArray[i] = arr[i]; 
                }
                else if (i == Index)
                {
                    newArray[i] = X; 
                }
                else
                {
                    newArray[i] = arr[i - 1]; 
                }
            }

            Console.WriteLine("Array after insertion:");
            foreach (int value in newArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
