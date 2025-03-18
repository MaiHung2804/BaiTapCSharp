using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] num = new int[5];
            num[0] = 2;
            num[1] = 5 ;
            num[2] = 9 ;
            num[3] = 6 ;
            num[4] = 7 ;
            Console.WriteLine(num[0]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);
            for(int i =0; i<num.Length; i++)
            {
                total += num[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}
