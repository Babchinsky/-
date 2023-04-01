using System;
using System.Collections.Generic;
using System.Threading;

namespace _40a_hw_31._03._2023_ObserverPattern
{
    public interface IObserver
    {
        // Получает обновление от издателя
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(IObserver observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(IObserver observer);

        // Уведомляет всех наблюдателей о событии.
        void Notify();
    }

    // Издатель владеет некоторым важным состоянием и оповещает наблюдателей о
    // его изменениях.
    public class Subject : ISubject
    {
        // Для удобства в этой переменной хранится состояние Издателя,
        // необходимое всем подписчикам.
        public int State { get; set; } = -0;

        // Список подписчиков. В реальной жизни список подписчиков может
        // храниться в более подробном виде (классифицируется по типу события и
        // т.д.)
        private List<IObserver> _observers = new List<IObserver>();

        // Методы управления подпиской.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Магазин: Прикрепил наблюдателя.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Магазин: Отделил наблюдателя.");
        }

        // Запуск обновления в каждом подписчике.
        public void Notify()
        {
            Console.WriteLine("Магазин: Уведомление наблюдателей...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Обычно логика подписки – только часть того, что делает Издатель.
        // Издатели часто содержат некоторую важную бизнес-логику, которая
        // запускает метод уведомления всякий раз, когда должно произойти что-то
        // важное (или после этого).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nМагазин: В магазин едет новый товар.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("\nМагазин: В магазин приехало " + this.State + " единиц товара");
            this.Notify();
        }
    }

    // Конкретные Наблюдатели реагируют на обновления, выпущенные Издателем, к
    // которому они прикреплены.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine($"Наблюдатель1: Отреагировал на событие. Новых товаров: {(subject as Subject).State}");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine($"Наблюдатель1: Отреагировал на событие. Новых товаров: {(subject as Subject).State}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
