using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.States
{
    public abstract class State
    {
        protected Game game;

        protected int level;
        protected int hitPoints;

        public abstract void NextLevel();
        public abstract void GetHit();
    }
}
