using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNTNhoHon100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach STN < 100: ");
            int dem = 0;
            for( int i=2; i<100; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    if (i%j == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    Console.WriteLine(i);
                }
                dem = 0;
            }
        }
    }
}
