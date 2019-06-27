using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    class NewGameState : State
    {
        public NewGameState(Game game)
        {
            this.game = game;
            level = 0;
            this.NextLevel();
        }
        public override void GetHit()
        {
            Console.WriteLine("you just start the game");
        }

        public override void NextLevel()
        {
            level++;
            this.game.State = new SpaceshipOKState(game);
        }
    }
}
