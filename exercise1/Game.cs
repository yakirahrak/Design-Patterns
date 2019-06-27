using exercise1.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Game
    {
        public State State { get; set; }

        public Game()
        {
            State = new NewGameState(this);
        }

        public void GetHit()
        {
            this.State.GetHit();
        }

        public void NextLevel()
        {
            this.State.NextLevel();
        }
    }
}
