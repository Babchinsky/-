using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36a_hw_27._03._2023_FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine(human);

            Console.WriteLine();

            HumanDecorator humanWarrior = new HumanWarrior(human);
            Console.WriteLine(humanWarrior);

            Console.WriteLine();

            HumanWarriorDecorator swordsman = new HumanSwordsman(humanWarrior);
            Console.WriteLine(swordsman);

            Console.WriteLine();

            HumanWarriorDecorator archer = new HumanArcher(humanWarrior);
            Console.WriteLine(archer);

            Console.WriteLine();

            HumanSwordsmanDecorator rider = new HumanRider(swordsman);
            Console.WriteLine(rider);
        }
    }
}
