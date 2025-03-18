using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Console.WriteLine("Enter the number of bilionaires(Maximun 20): ");
            int count = Int32.Parse(Console.ReadLine());
            if (count > 20)
            {
                Console.WriteLine("The number cannot exceed 20");
                return;
            }
            if(count <= 0)
            {
                Console.WriteLine("The number must be greater than 0");
                return;
            }
            for(int i=0; i<count; i++)
            {
                Console.WriteLine($"Enter the wealth of billionaire{i + 1} (in billions): ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            int maxValue = array[0];
            int maxIndex = 0;
            for(int i = 1; i < count; i++)
            {
                if (array[i]> maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Position in the list: {maxIndex + 1}");
            Console.WriteLine($"The largest wealth is: {maxValue} ");
        }
    }
}
