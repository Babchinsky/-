using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_myHW_Car_Fabric_21._03._2023
{
    #region Engine
    interface IEngine
    {
        void ReleaseEngine();
    }

    class JapaneseEngine :IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Выпуск японского двигателя");
    }

    class GermanyEngine :IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Выпуск немецкого двигателя");
    }
    #endregion

    #region Car
    interface ICar
    {
        void ReleaseCar();
    }

    class JapaneseCar : ICar
    {
        public void ReleaseCar() => Console.WriteLine("Выпуск японской машины");
    }

    class GermanyCar : ICar
    {
        public void ReleaseCar() => Console.WriteLine("Выпуск немецкой машины");
    }
    #endregion

    #region Factory
    interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }

    class JapaneseFactory : IFactory 
    {
        public ICar CreateCar() => new JapaneseCar();
        public IEngine CreateEngine() => new JapaneseEngine();
    }

    class GermanyFactory : IFactory
    {
        public ICar CreateCar() => new GermanyCar();
        public IEngine CreateEngine() => new GermanyEngine();
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory jFactory = new JapaneseFactory();
            
            IEngine jEngine = jFactory.CreateEngine();
            ICar jCar = jFactory.CreateCar();


            IFactory gFactory = new GermanyFactory();

            IEngine gEngine = gFactory.CreateEngine();
            ICar gCar = gFactory.CreateCar();
        }
    }
}
