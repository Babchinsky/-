using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39a_hw_30._03._2023_mediator_pattern
{
    // The 'Mediator' abstract class
    abstract class AbstractChatroom 
    {
        public abstract void Register(Participant participant);
	    public abstract void Send(string from, string to, string message);
    };

    class Chatroom : AbstractChatroom
    {
        Dictionary<string, Participant> participants;

        public override void Register(Participant participant)
        {
            if (!participants.ContainsKey(participant.GetName()))
            {
                participants[participant.GetName()] = participant;
            }
            participant.SetChatroom(this);
        }
        public override void Send(string from, string to, string message)
        {
            Participant participant = participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

    }
}
