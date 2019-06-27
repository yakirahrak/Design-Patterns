using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    class SpaceshipInDangerState:State
    {
        private const int winnigLevel = 4;

        public SpaceshipInDangerState(Game game)
        {
            this.game = game;
        }

        public override void GetHit()
        {
            hitPoints--;
            if (hitPoints == 0)
            {
                game.State = new LossState(game);
            }
        }

        public override void NextLevel()
        {
            level++;
            if(level== winnigLevel)
            {
                game.State = new WinnigState(game);
            }
        }
    }
}
