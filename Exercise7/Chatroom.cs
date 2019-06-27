using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    abstract class AbstractChatroom

    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
        public abstract void SendAll(string from, string message);
    }

    class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

        public override void SendAll(string from, string message)
        {
            foreach (var participant in _participants.Values)
            {
                participant.Receive(from, message);
            }
        }
    }

}
