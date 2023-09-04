using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36a_hw_27._03._2023_FacadePattern
{
    abstract class HumanWarriorDecorator : HumanWarrior
    {
        public HumanWarriorDecorator() : base()
        {

        }
    }

    class HumanSwordsman : HumanWarriorDecorator
    {
        public HumanSwordsman()
        {

        }
        public HumanSwordsman(HumanDecorator humanWarrior)
        {
            this.Name = "Меченосец";
            this.Attack = humanWarrior.Attack + 40;
            this.Speed = humanWarrior.Speed - 10;
            this.Health = humanWarrior.Health + 50;
            this.Defense = humanWarrior.Defense + 40;
        }
    }

    class HumanArcher : HumanWarriorDecorator
    {
        public HumanArcher()
        {

        }
        public HumanArcher(HumanDecorator humanWarrior)
        {
            this.Name = "Лучник";
            this.Attack = humanWarrior.Attack + 20;
            this.Speed = humanWarrior.Speed + 20;
            this.Health = humanWarrior.Health + 50;
            this.Defense = humanWarrior.Defense + 10;
        }
    }

    abstract class HumanSwordsmanDecorator : HumanSwordsman
    {
        public HumanSwordsmanDecorator() : base()
        {

        }
    }

    class HumanRider : HumanSwordsmanDecorator
    {
        public HumanRider()
        {

        }
        public HumanRider(HumanWarriorDecorator humanSwordsman)
        {
            this.Name = "Всадник";
            this.Attack = humanSwordsman.Attack - 10;
            this.Speed = humanSwordsman.Speed + 40;
            this.Health = humanSwordsman.Health + 200;
            this.Defense = humanSwordsman.Defense + 100;
        }
    }
}
