using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    class WinnigState : State
    {
        public WinnigState(Game game)
        {
            this.game = game;
        }
        public override void GetHit()
        {
            Console.WriteLine("you already win");
        }

        public override void NextLevel()
        {
            Console.WriteLine("you already win");
        }
    }
}
