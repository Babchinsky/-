using System;
using System.Collections.Generic;

class SnakeGame
{
    static int width = 20;
    static int height = 10;
    static int score = 0;
    static bool gameover = false;
    static Random random = new Random();

    static int headX = width / 2;
    static int headY = height / 2;
    static List<int> bodyX = new List<int>();
    static List<int> bodyY = new List<int>();
    static int foodX = random.Next(0, width);
    static int foodY = random.Next(0, height);
    static int dx = 0;
    static int dy = 0;

    static void Main()
    {
        Console.CursorVisible = false;

        while (!gameover)
        {
            DrawBoard();
            HandleInput();
            MoveSnake();
            CheckCollision();
            CheckFood();
            System.Threading.Thread.Sleep(100);
        }

        Console.WriteLine("Game over. Your score is: " + score);
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.SetCursorPosition(headX, headY);
        Console.Write("@");

        for (int i = 0; i < bodyX.Count; i++)
        {
            Console.SetCursorPosition(bodyX[i], bodyY[i]);
            Console.Write("#");
        }

        Console.SetCursorPosition(foodX, foodY);
        Console.Write("X");

        Console.SetCursorPosition(0, height);
        Console.WriteLine("Score: " + score);
    }

    static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                dx = -1;
                dy = 0;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                dx = 1;
                dy = 0;
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                dx = 0;
                dy = -1;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                dx = 0;
                dy = 1;
            }
        }
    }

    static void MoveSnake()
    {
        bodyX.Insert(0, headX);
        bodyY.Insert(0, headY);

        headX += dx;
        headY += dy;

        if (bodyX.Count > score)
        {
            bodyX.RemoveAt(bodyX.Count - 1);
            bodyY.RemoveAt(bodyY.Count - 1);
        }
    }

    static void CheckCollision()
    {
        if (headX < 0 || headX >= width || headY < 0 || headY >= height)
        {
            gameover = true;
        }

        for (int i = 0; i < bodyX.Count; i++)
        {
            if (headX == bodyX[i] && headY == bodyY[i])
            {
                gameover = true;
            }
        }
    }

    static void CheckFood()
    {
        if (headX == foodX && headY == foodY)
        {
            score++;
            foodX = random.Next(0, width);
            foodY = random.Next(0, height);
        }
    }
}
