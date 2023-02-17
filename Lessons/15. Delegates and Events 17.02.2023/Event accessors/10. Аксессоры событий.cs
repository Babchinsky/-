using System;
using System.Collections.Generic;
namespace Events
{
    delegate void MyDelegate();
    class SourceEvent
    {
        List<MyDelegate> list = new List<MyDelegate>();

        // ��� ���������� ������� ������������ ������� ������ 
        // ����������� ����� ��������� event, ����������� ������������ ��������� �������. 
        // ��� ��������� ������������� �������� ��� ���������� ����������� ��������� ������. 
        // �������� ���������� WPF ���������� ���� ������ ��� ���������� ���������������� 
        // "������������" � ����������� ��������������� �������.

        public event MyDelegate ev
        {
            // ���������� ��������� �������
            add
            {
                list.Add(value);
            }

            remove
            {
                list.Remove(value);
            }
        }
        public void GeneratorEvent()
        {
            Console.WriteLine("��������� �������!!!");
            if (list.Count != 0)
                foreach(MyDelegate i in list)
                {
                    i();
                }
        }
    }

    class ObserverEventA
    {
        public void see()
        {
            Console.WriteLine("ObserverEventA. ������� ����������! ");
        }
    }

    class ObserverEventB
    {
        public void see()
        {
            Console.WriteLine("ObserverEventB. ������� ����������!");
        }
    }

    class MainClass
    {
        static void Main()
        {
            SourceEvent s = new SourceEvent(); // ������ ������-��������� �������
            ObserverEventA obj1 = new ObserverEventA(); // ������ ������ �����������
            ObserverEventA obj2 = new ObserverEventA(); // ������ ������ �����������
            ObserverEventB obj3 = new ObserverEventB(); // ������ ������ �����������
            ObserverEventB obj4 = new ObserverEventB(); // ������ ������ �����������

            // ���������� ������������ � �������
            s.ev += new MyDelegate(obj1.see);
            s.ev += new MyDelegate(obj2.see);
            s.ev += new MyDelegate(obj3.see);
            s.ev += new MyDelegate(obj4.see);

            s.GeneratorEvent(); // ������������� �������

            s.ev -= obj3.see;
            s.ev -= obj4.see;

            s.GeneratorEvent(); // ������������� �������
        }
    }

}
