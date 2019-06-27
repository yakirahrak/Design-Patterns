using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Exercise7
    {
        public static void Start()
        {
            Chatroom chatroom = new Chatroom();
            Participant a = new Participant("yossi");
            Participant b = new Participant("david");
            Participant c = new Participant("moshe");

            chatroom.Register(a);
            chatroom.Register(b);
            chatroom.Register(c);

            a.Send("david", "hello david");
            a.SendToAll("hello everyone");
        }
    }
}
