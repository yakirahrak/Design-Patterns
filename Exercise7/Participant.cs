using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Participant
    {
        public Chatroom Chatroom { get; set; }
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(_name, to, message);
        }

        // Include himself
        public void SendToAll(string message)
        {
            Chatroom.SendAll(_name, message);
        }

        public virtual void Receive(string sender, string message)
        {
            Console.WriteLine("from {0}: '{1}'", sender, message);
        }
    }

}
