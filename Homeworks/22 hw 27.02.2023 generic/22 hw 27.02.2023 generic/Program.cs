using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_hw_27._02._2023_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            Task_3();
            //Task_4();
            //Task_5();
        }

        static void Task_1()
        {
            int x = 1, y = 2;
            Swap(ref x, ref y);
            Console.WriteLine($"X: {x}\tY: {y}");


            string s1 = "hello", s2 = "world";
            Swap(ref s1, ref s2);
            Console.WriteLine($"S1: {s1}\tS2: {s2}");
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Task_2()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(1);


            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue);
            Console.WriteLine(priorityQueue.Count);
            Console.WriteLine(priorityQueue.Peek());
        }
        public class PriorityQueue<T>
        {
            private List<T> heap;
            private IComparer<T> comparer;
    
            public int Count => heap.Count;
    
            public PriorityQueue(IComparer<T> comparer = null)
            {
                heap = new List<T>();
                this.comparer = comparer ?? Comparer<T>.Default;
            }
    
            public void Enqueue(T item)
            {
                heap.Add(item);
                int i = heap.Count - 1;
                while (i > 0)
                {
                    int parent = (i - 1) / 2;
                    if (comparer.Compare(heap[parent], heap[i]) <= 0)
                    {
                        break;
                    }
                    T temp = heap[parent];
                    heap[parent] = heap[i];
                    heap[i] = temp;
                    i = parent;
                }
            }
    
            public T Dequeue()
            {
                if (heap.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty.");
                }
                T result = heap[0];
                int last = heap.Count - 1;
                heap[0] = heap[last];
                heap.RemoveAt(last);
                last--;
                int i = 0;
                while (true)
                {
                    int left = 2 * i + 1;
                    int right = 2 * i + 2;
                    if (left > last)
                    {
                        break;
                    }
                    int minChild = left;
                    if (right <= last && comparer.Compare(heap[right], heap[left]) < 0)
                    {
                        minChild = right;
                    }
                    if (comparer.Compare(heap[i], heap[minChild]) <= 0)
                    {
                        break;
                    }
                    T temp = heap[minChild];
                    heap[minChild] = heap[i];
                    heap[i] = temp;
                    i = minChild;
                }
                return result;
            }
    
            public T Peek()
            {
                if (heap.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty.");
                }
                return heap[0];
            }
            public override string ToString()
            {
                string buf = string.Empty;
                foreach (var item in heap)
                    buf += item + " ";
                return buf;
            }
        }

        static void Task_3()
        {
            CircularQueue<int> queue = new CircularQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Enqueue(6);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue size: " + queue.Count);
            Console.WriteLine("Queue is empty: " + queue.IsEmpty);
            Console.WriteLine("Queue is full: " + queue.IsFull);
            Console.WriteLine("Queue elements: " + queue.ToString());

        }
        public class CircularQueue<T> : IEnumerable<T>
        {
            private T[] _items;
            private int _head;
            private int _tail;
            private int _size;
    
            public CircularQueue(int capacity = 10)
            {
                _items = new T[capacity];
                _head = 0;
                _tail = 0;
                _size = 0;
            }
    
            public int Count { get { return _size; } }
    
            public bool IsEmpty { get { return _size == 0; } }
    
            public bool IsFull { get { return _size == _items.Length; } }
    
            public void Enqueue(T item)
            {
                if (IsFull)
                {
                    throw new InvalidOperationException("Queue is full");
                }
    
                _items[_tail] = item;
                _tail = (_tail + 1) % _items.Length;
                _size++;
            }
    
            public T Dequeue()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("Queue is empty");
                }
    
                T item = _items[_head];
                _head = (_head + 1) % _items.Length;
                _size--;
                return item;
            }
    
            public T Peek()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("Queue is empty");
                }
    
                return _items[_head];
            }
    
            public void Clear()
            {
                _head = 0;
                _tail = 0;
                _size = 0;
            }
    
            public IEnumerator<T> GetEnumerator()
            {
                int index = _head;
                for (int i = 0; i < _size; i++)
                {
                    yield return _items[index];
                    index = (index + 1) % _items.Length;
                }
            }
    
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
    
            public override string ToString()
            {
                return string.Join(", ", this);
            }
        }
        static void Task_4()
        {

        }
        static void Task_5()
        {

        }
    }
}
