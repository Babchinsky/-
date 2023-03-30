using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39a_hw_30._03._2023_mediator_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractChatroom chatroom = new Chatroom();

            Participant[] participants =
            {
                new Beatles("George"),
                new Beatles("Paul"),
                new Beatles("Ringo"),
                new Beatles("John"),
                new NonBeatles("Yoko")
            };

            Registration(chatroom, participants, 5);

            //Chat(participants[4], "John", "Hi John!");
            //Chat(participants[1], "Ringo", "All you need is love");
            //Chat(participants[2], "George", "My sweet Lord");
            //Chat(participants[1], "John", "Can't buy me love");
            //Chat(participants[3], "Yoko", "My sweet love");
        }

        public static void Registration(AbstractChatroom chatroom, Participant[] participants, int size)
        {
            for (int i = 0; i < size; i++)
                chatroom.Register(participants[i]);
        }

        public static void Chat(Participant participants, string to, string message)
        {
            participants.Send(to, message);
        }
    }
}
