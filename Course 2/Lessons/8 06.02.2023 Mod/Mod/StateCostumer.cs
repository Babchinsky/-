﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod
{
    class StateConsumer
    {
        public void PrintState()
        {
            State state = new State();

            // обратиться к переменной defaultVar у нас не получится,
            // так как она имеет модификатор private и класс StateConsumer ее не видит
            Console.WriteLine(state.defaultVar); //Ошибка, получить доступ нельзя

            // то же самое относится и к переменной privateVar
            Console.WriteLine(state.privateVar); // Ошибка, получить доступ нельзя

            // обратиться к переменной protectedPrivateVar не получится,
            // так как класс StateConsumer не является классом-наследником класса State
            Console.WriteLine(state.protectedPrivateVar); // Ошибка, получить доступ нельзя

            // обратиться к переменной protectedVar тоже не получится,
            // так как класс StateConsumer не является классом-наследником класса State
            Console.WriteLine(state.protectedVar); // Ошибка, получить доступ нельзя

            // переменная internalVar с модификатором internal доступна из любого места текущего проекта
            // поэтому спокойно присваиваем ей значение
            Console.WriteLine(state.internalVar);

            // переменная protectedInternalVar так же доступна из любого места текущего проекта
            Console.WriteLine(state.protectedInternalVar);

            // переменная publicVar общедоступна
            Console.WriteLine(state.publicVar);
        }
    }
}
