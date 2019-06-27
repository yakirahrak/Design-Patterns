using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    class LossState : State
    {
        public LossState(Game game)
        {
            this.game = game;
        }
        public override void GetHit()
        {
            Console.WriteLine("you already lose");
        }

        public override void NextLevel()
        {
            Console.WriteLine("you already lose");
        }
    }
}
