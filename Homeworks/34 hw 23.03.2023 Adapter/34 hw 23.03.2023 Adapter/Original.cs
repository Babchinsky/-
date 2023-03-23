using System;

namespace _34_hw_23._03._2023_Adapter
{
    // Класс Original
    public class Original
    {
        public void OriginalDouble(double d)
        {
            Console.WriteLine(d);
        }

        public void OriginalInt(int i)
        {
            Console.WriteLine(i * 2);
        }

        public void OriginalChar(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
