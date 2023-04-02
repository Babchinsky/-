using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36a_hw_27._03._2023_FacadePattern
{
    public class Human
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }

        public Human()
        {
            Name = "Человек";
            Attack = 20;
            Speed = 20;
            Health = 150;
            Defense = 0;
        }

        public Human(string name, int attack, int speed, int health, int defense)
        {
            Name = name;
            Attack = attack;
            Speed = speed;
            Health = health;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAttack: {Attack}\nSpeed: {Speed}\nHealth: {Health}\nDefense: {Defense}";
        }
    }


    abstract class HumanDecorator : Human
    {
        public HumanDecorator(): base(null,0, 0, 0, 0)
        {

        }
    }

    class HumanWarrior : HumanDecorator
    {
        public HumanWarrior()
        {

        }
        public HumanWarrior(Human human): base()
        {
            this.Name = human.Name + "-воин";
            this.Attack = human.Attack + 20;
            this.Speed = human.Speed + 10;
            this.Health = human.Health + 50;
            this.Defense = human.Defense + 20;
        }
    }
}
