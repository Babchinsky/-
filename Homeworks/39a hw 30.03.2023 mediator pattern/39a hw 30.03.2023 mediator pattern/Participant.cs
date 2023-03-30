using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _39a_hw_30._03._2023_mediator_pattern
{
    abstract class Participant 
    {
	    AbstractChatroom chatroom;
        string name;

        public Participant(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public AbstractChatroom GetChatroom()
        {
            return chatroom;
        }
        public void SetChatroom(AbstractChatroom chatroom)
        {
            this.chatroom = chatroom;
        }
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine(from + " to " + name + ": '" + message + "'");
        }
    }
}
