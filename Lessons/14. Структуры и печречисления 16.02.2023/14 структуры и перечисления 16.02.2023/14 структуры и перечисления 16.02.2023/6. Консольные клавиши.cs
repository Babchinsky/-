using System;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            char keyChar;
            do
            {
                // Console.ReadKey() получает следующий нажатый пользователем символ или функциональную клавишу. 
                // Нажатая клавиша отображается в окне консоли. 
                ConsoleKeyInfo info = Console.ReadKey();
                // ConsoleKeyInfo описывает нажатую клавишу консоли, включая символ, представленный этой клавишей, 
                // и состояние управляющих клавиш CTRL, SHIFT и ALT.
                key = info.Key; // Возвращает клавишу консоли, представленную текущим объектом ConsoleKeyInfo.
                Console.WriteLine(key);
            } while (key != ConsoleKey.Escape);

            do
            {
                ConsoleKeyInfo info = Console.ReadKey();
                keyChar = info.KeyChar;
                Console.WriteLine(keyChar); // Возвращает символ Юникода, представленный текущим объектом ConsoleKeyInfo.
            } while (keyChar != 27);

        }
    }
}