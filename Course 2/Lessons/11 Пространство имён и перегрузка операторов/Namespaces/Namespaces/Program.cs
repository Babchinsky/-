using System;
using A.B;
using static System.Console;
using AliasAB = A.B;
using AliasABTest = A.B.Test;

namespace A
{
    namespace B
    {
        class Test
        {
            public static void f()
            {
                System.Console.WriteLine("Test");
                Console.WriteLine("Test");
                WriteLine("Test");
            }
        }
    }
}

namespace C
{
    class MainClass
    {
        static void Main()
        {
            A.B.Test.f();
            // B.Test.f(); 
            Test.f();
            AliasAB.Test.f();
            AliasABTest.f();
        }
    }
}

