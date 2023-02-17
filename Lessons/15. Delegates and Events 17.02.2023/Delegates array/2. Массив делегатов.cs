using System;
namespace Delegate
{
    delegate int MyDelegate(int a, int b, int c);

    class Class1
    {
        public static int Max(int a, int b, int c)
        {
            Console.WriteLine("�������� �� ��� �����:");
            return Math.Max(Math.Max(a, b), c);
        }
        public static int Min(int a, int b, int c)
        {
            Console.WriteLine("������� �� ��� �����:");
            return Math.Min(Math.Min(a, b), c);
        }
        public static int Sum(int a, int b, int c)
        {
            Console.WriteLine("����� ��� �����:");
            return a + b + c;
        }
        public static int Mult(int a, int b, int c)
        {
            Console.WriteLine("������������ ��� �����:");
            return a * b * c;
        }
        
        //public static void Func(int a, int b, int c, MyDelegate ptr)
        //{
        //    ptr(a, b, c);
        //}


        static void Main(string[] args)
        {

            //Func(1, 2, 3, Max);
            //Func(1, 2, 3, Min);



            //MyDelegate[] dg = new MyDelegate[4] { new MyDelegate(Max), new MyDelegate(Min), new MyDelegate(Sum), new MyDelegate(Mult) };
            //MyDelegate[] dg = new MyDelegate[4] {Max, Min, Sum, Mult};
            MyDelegate[] dg = { Max, Min, Sum, Mult };
            int choice = 0;
            while (choice != 5)
            {
                Console.Write("\n1 Max\n2 Min \n3 Sum\n4 Mult\n5 Exit\nYour choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("������� ��� �����: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(dg[choice - 1].Invoke(a, b, c));
                }
            }
        }
    }
}
