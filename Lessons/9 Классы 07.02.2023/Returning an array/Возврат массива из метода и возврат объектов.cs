using System;

namespace CSharp.Return
{
    class Car
    {
        public string CarName { get; set; } = "BMW";
    }
    class Sample
    {
        static Car MakeNewCar(string s)
        {
            Car z = new Car();
            z.CarName = s;
            return z;
        }
        static int[] MakeArray(int s)
        {
            int[] ar = new int[s];
            for (int i = 0; i < ar.Length; i++)
                ar[i] = (i + 1) * 10;
            return ar;
        }
        public static void Main()
        {
            Car c = MakeNewCar("BMW");
            Console.WriteLine(c.CarName);
            int[] p = MakeArray(3);
            foreach (int i in p)
                Console.Write("{0,4}", i);
        }
    }
}
