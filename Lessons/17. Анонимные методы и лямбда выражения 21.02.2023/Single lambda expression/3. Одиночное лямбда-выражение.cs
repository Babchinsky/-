using System;

namespace Anonymous_methods
{
    class MainClass
    {
        delegate int Square(int x);
        delegate int Mult(int i, int y);
        delegate void message(); 

        static void Main(string[] args)
        {
            //Square square = delegate (int t)
            //{
            //    return t * t;
            //};
            //Console.WriteLine(square(2));

            Square squareInt = i => i * i;

            Console.WriteLine("������� �����: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = squareInt(number); 
            Console.WriteLine("������� ����� {0} ����� {1}", number, result);

            Console.WriteLine("������� ������ �����: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ������ �����: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Mult mult = (x, y) => x * y;
            Console.WriteLine("������������ ����� �����: " + mult(n1, n2));

            message GetMessage = () => Console.WriteLine("������-���������"); 
            GetMessage();
        }
    }
}


