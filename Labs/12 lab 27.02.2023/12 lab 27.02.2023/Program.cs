using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lab_27._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            Task_5();
        }
        static void Task_1()
        {
            int maxInt = Max<int>(10, 5, 15); // возвращает 15
            Console.WriteLine(maxInt);
            double maxDouble = Max<double>(2.5, 7.8, 5.3); // возвращает 7.8
            Console.WriteLine(maxDouble);

        }
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }

        static void Task_2()
        {
            int maxInt = Min<int>(10, 5, 15); // возвращает 15
            Console.WriteLine(maxInt);
            double maxDouble = Min<double>(2.5, 7.8, 5.3); // возвращает 7.8
            Console.WriteLine(maxDouble);

        }
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) < 0)
            {
                max = b;
            }
            if (c.CompareTo(max) < 0)
            {
                max = c;
            }
            return max;
        }
        static void Task_3()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int sumInt = Sum(intArray); // возвращает 15
            Console.WriteLine(sumInt);

            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double sumDouble = Sum(doubleArray); // возвращает 16.5
            Console.WriteLine(sumDouble);
        }
        public static T Sum<T>(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("The array parameter cannot be null or empty");
            }

            T sum = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                sum = (dynamic)sum + array[i];
            }
            return sum;
        }

        static void Task_4()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            
            Console.WriteLine(stack);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
        }
        public class Stack<T>
        {
            private List<T> items = new List<T>();

            public void Push(T item)
            {
                items.Add(item);
            }

            public T Pop()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("Стек пуст");
                }

                T item = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return item;
            }

            public T Peek()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("Стек пуст");
                }

                return items[items.Count - 1];
            }

            public int Count
            {
                get { return items.Count; }
            }
            public override string ToString()
            {
                string buf = string.Empty;

                foreach (var item in items)
                    buf += item.ToString() + " ";
                return buf;
            }
        }


        static void Task_5()
        {
            Queue<int> queue = new Queue<int>(1);
            queue.Enqueue(7);
            Console.WriteLine(queue);
            //queue.Dequeue();
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
        }


        public class Queue<T>
        {
            private T[] elements;
            private int head;
            private int tail;

            public Queue(int capacity)
            {
                if (capacity <= 0) throw new Exception("Invalid size of queue");
                
                elements = new T[capacity];
                head = 0;
                tail = -1;
            }

            public void Enqueue(T item)
            {
                if (tail == elements.Length - 1)
                {
                    Array.Resize(ref elements, elements.Length * 2);
                }

               elements[++tail] = item;
            }

            public T Dequeue()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }
    
                T item = elements[head++];
                if (head > tail)
                {
                    head = 0;
                    tail = -1;
                }

                return item;
            }

            public T Peek()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }

                return elements[head];
            }
            
            public int Count
            {
                get { return tail - head + 1; }
            }

            public override string ToString()
            {
                string buf = string.Empty;

                foreach (var item in elements)
                    buf += item.ToString() + " ";
                return buf;
            }
        }
    }
}
