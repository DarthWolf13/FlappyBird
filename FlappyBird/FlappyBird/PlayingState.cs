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

        public void SetGameOver()
        {
            bird.Reset();
            pipes.Objects.Clear();
            FrameCounter = 0;
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

            Boolean IsGameOver = false;
            
            if (bird.Position.Y > FlappyBird.Screen.Y || bird.Position.Y < 0 || bird.CollidesWith(pipe))
            {
                IsGameOver = true;
            } 
            
            if (IsGameOver == true)
            {
                SetGameOver();
            }                     
        }      
    }
}
