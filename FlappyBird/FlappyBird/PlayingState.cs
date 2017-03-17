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
        Score score;

        public PlayingState()
        {
            bird = new Bird();
            pipes = new GameObjectList();
            score = new Score();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
            this.Add(pipes);
            this.Add(score);
        }

        public void SetGameOver()
        {
            FlappyBird.GameStateManager.SwitchTo("GameOverState");
            bird.Reset();
            pipes.Objects.Clear();
            FrameCounter = 0;
            score.ScoreValue = 0;
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
            
            if (bird.Position.Y > FlappyBird.Screen.Y || bird.Position.Y < 0)
            {
                IsGameOver = true;
            }

            foreach (Pipe pipes in pipes.Objects)
            {
                if (bird.CollidesWith(pipes))
                {
                    IsGameOver = true;
                }

                if (pipes.Position.X + pipes.Width < bird.Width)
                {
                    score.ScoreValue++;
                }

                if (pipes.Position.X + pipes.Width < 0)
                {
                    this.pipes.Remove(pipes);
                    break;
                }
            }

            if (IsGameOver == true)
            {
                SetGameOver();
            }                     
        }      
    }
}
