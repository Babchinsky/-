using System;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            int x = 0, y = 0;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write((char)2);
                // Console.ReadKey() получает следующий нажатый пользователем символ или функциональную клавишу. 
                // Нажатая клавиша отображается в окне консоли. 
                ConsoleKeyInfo info = Console.ReadKey();
                // ConsoleKeyInfo описывает нажатую клавишу консоли, включая символ, представленный этой клавишей, 
                // и состояние управляющих клавиш CTRL, SHIFT и ALT.
                key = info.Key;// Возвращает клавишу консоли, представленную текущим объектом ConsoleKeyInfo.
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                            --x;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 1)
                            ++x;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                            --y;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 1)
                            ++y;
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}
