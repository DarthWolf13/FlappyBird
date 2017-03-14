using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FlappyBird
{
    class PlayingState : GameObjectList
    {
        Bird bird;
        GameObjectList pipes;
        int FrameCounter;

        public PlayingState()
        {
            bird = new Bird();
            pipes = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
            this.Add(pipes);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            FrameCounter += 1;
            if (FrameCounter > 100)
            {
                this.pipes.Add(new Pipe());
                FrameCounter = 0;
            }
                

        }
    }
}
