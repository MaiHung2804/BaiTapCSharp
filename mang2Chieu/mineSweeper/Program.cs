using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mineSweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
             char[,] map = {
                { '*', '.', '.', '.' },
                { '.', '.', '.', '.' },
                { '.', '*', '.', '.' },
                { '.', '.', '.', '.' }
            };

            int HEIGHT = map.GetLength(0);
            int WIDTH = map.GetLength(1);
            char[,] report = new char[HEIGHT, WIDTH];

            (int dy, int dx)[] directions = {
                (-1, -1), (-1, 0), (-1, 1),
                (0, -1),          (0, 1),
                (1, -1),  (1, 0),  (1, 1)
            };

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (map[y, x] == '*')
                    {
                        report[y, x] = '*';
                        continue;
                    }

                    int mines = 0;
                    foreach (var (dy, dx) in directions)
                    {
                        int newY = y + dy, newX = x + dx;
                        if (newY >= 0 && newY < HEIGHT && newX >= 0 && newX < WIDTH && map[newY, newX] == '*')
                        {
                            mines++;
                        }
                    }
                    report[y, x] = (char)('0' + mines);
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    sb.Append(report[y, x]);
                }
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
