using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39b_hw_39._03._2023_IteratorPattern_2._0
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }


    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Возвращает ключ текущего элемента
        public abstract int Key();

        // Возвращает текущий элемент.
        public abstract object Current();

        // Переходит к следующему элементу.
        public abstract bool MoveNext();

        // Перематывает Итератор к первому элементу.
        public abstract void Reset();
    }

    // Конкретные Итераторы реализуют различные алгоритмы обхода. Эти классы
    // постоянно хранят текущее положение обхода.
    class OrderIterator : Iterator
    {
        private WalksCollection walks;
        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации, особенно когда он
        // должен работать с определённым типом коллекции.
        private int position = -1;
        private bool reverse = false;

        public OrderIterator(WalksCollection walks, bool reverse)
        {
            this.walks = walks;
            this.reverse = reverse;

            if (reverse)
            {
                this.position = walks.getItems().Length;
            }
        }

        public override object Current()
        {
            return this.walks.getItems()[position];
        }

        public override int Key()
        {
            return this.position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this.position + (this.reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this.walks.getItems().Length)
            {
                this.position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this.position = this.reverse ? this.walks.getItems().Length - 1 : 0;
        }
    }
}
