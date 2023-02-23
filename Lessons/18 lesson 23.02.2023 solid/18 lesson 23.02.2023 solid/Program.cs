using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_lesson_23._02._2023_solid
{
    internal class Program
    {
        interface IAnimal
        {
            void Eat();
            void Drink();
        }

        interface IFly
        {
            void Fly();
        }
        interface ISwim
        {
            void Swim();
        }
        interface IJump
        {
            void Jump();
        }

        class Elephant : IAnimal
        {
            public void Drink()
            {
                throw new NotImplementedException();
            }

            public void Eat()
            {
                throw new NotImplementedException();
            }

        }
        class Penguin: IAnimal, ISwim, IJump
        {
           
        }

        class Parrot: IAnimal, IFly, IJump
        {

        }

        static void Main(string[] args)
        {
        }
    }
}
