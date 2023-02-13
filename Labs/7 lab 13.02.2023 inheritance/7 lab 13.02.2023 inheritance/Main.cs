using System;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Program
    {
        static void Main()
        {
            //Task_1();
            //Task_2();
            //Task_3();
            Task_4();
        }
        public static void Task_1()
        {
            Console.WriteLine("\t\t\tTask 1");

            Human ptr = new Human();
            //ptr.Print();
            Console.WriteLine(ptr);

            ptr = new Builder("Victor", 32, 2000);
            Console.WriteLine(ptr);
            ptr.Print();
        }
        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2");
            Passport ptr = new Passport();
            //Console.WriteLine(ptr);
            //ptr.Print();

            ptr = new ForeignPassport("Ivan Maksimov", new DateTime(2003, 07, 11), new DateTime(2033, 09, 23), "12312313", new string[] { "UA", "USA", "UK" },"UA1231231234");
            Console.WriteLine(ptr);
            ptr.Print();
        }
        public static void Task_3()
        {
            Console.WriteLine("\n\n\t\t\tTask 3");
            Animal ptr = new Animal();
            Console.WriteLine(ptr);


            ptr = new Tiger("Ivan Maksimov", 90, "Africa", "Simple");
            Console.WriteLine(ptr);
        }
        public static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");
            Figure ptr = null;
            ptr = new Rectangle(12, 4);
            Console.WriteLine(ptr);
            Console.WriteLine(ptr.GetArea());
        }
    }
}
