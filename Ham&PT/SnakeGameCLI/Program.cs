using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGameCLI
{
    internal class Program
    {
        static int width = 20;
        static int height = 20;
        static int score = 0;
        static int speed = 200; // Tốc độ bắt đầu

        static int foodX;
        static int foodY;

        static List<(int x, int y)> snake = new List<(int x, int y)>();
        static string direction = "RIGHT";
        static bool gameOver = false;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Setup();

            while (!gameOver)
            {
                Draw();
                Input();
                Logic();
                Thread.Sleep(speed); // Dùng biến speed
            }

            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.WriteLine("Score: " + score);
            Console.ReadKey();
        }

        static void Setup()
        {
            snake.Clear();
            snake.Add((width / 2, height / 2));
            direction = "RIGHT";
            score = 0;
            speed = 200;
            GenerateFood();
        }

        static void Draw()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                        Console.Write("#");
                    else if (x == snake[0].x && y == snake[0].y)
                        Console.Write("O");
                    else if (x == foodX && y == foodY)
                        Console.Write("*");
                    else
                    {
                        bool isBody = false;
                        for (int i = 1; i < snake.Count; i++)
                        {
                            if (snake[i].x == x && snake[i].y == y)
                            {
                                Console.Write("o");
                                isBody = true;
                                break;
                            }
                        }

                        if (!isBody)
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Score: " + score);
            Console.WriteLine("Speed: " + speed + "ms");
        }

        static void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W: if (direction != "DOWN") direction = "UP"; break;
                    case ConsoleKey.S: if (direction != "UP") direction = "DOWN"; break;
                    case ConsoleKey.A: if (direction != "RIGHT") direction = "LEFT"; break;
                    case ConsoleKey.D: if (direction != "LEFT") direction = "RIGHT"; break;
                    case ConsoleKey.X: gameOver = true; break;
                }
            }
        }

        static void Logic()
        {
            (int x, int y) head = snake[0];

            switch (direction)
            {
                case "UP": head.y--; break;
                case "DOWN": head.y++; break;
                case "LEFT": head.x--; break;
                case "RIGHT": head.x++; break;
            }

            if (head.x <= 0 || head.x >= width - 1 || head.y <= 0 || head.y >= height - 1)
            {
                gameOver = true;
                return;
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    gameOver = true;
                    return;
                }
            }

            snake.Insert(0, head);

            if (head.x == foodX && head.y == foodY)
            {
                score += 10;
                GenerateFood();

                // 👉 Tăng tốc: giảm speed 10ms mỗi lần, tối thiểu 50ms
                if (speed > 50)
                    speed -= 10;
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        static void GenerateFood()
        {
            Random rand = new Random();
            do
            {
                foodX = rand.Next(1, width - 2);
                foodY = rand.Next(1, height - 2);
            }
            while (snake.Exists(p => p.x == foodX && p.y == foodY));
        }
    }
}
