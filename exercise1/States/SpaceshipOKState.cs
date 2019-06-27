using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    class SpaceshipOKState : State
    {
        private const int spaceshipInDangerValue = 10;
        private const int winnigLevel = 4;
        public SpaceshipOKState(Game game)
        {
            this.game = game;
        }
        public override void GetHit()
        {
            hitPoints--;
            if(hitPoints<spaceshipInDangerValue)
            {
                game.State = new SpaceshipInDangerState(game);
            }
        }

        public override void NextLevel()
        {
            level++;
            if(level==4)
            {
                game.State = new WinnigState(game);
            }
        }
    }
}
