using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class PlayingState : GameObjectList
    {
        Bird bird;

        public PlayingState()
        {
            bird = new Bird();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
        }
    }
}
