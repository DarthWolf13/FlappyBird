using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Bird : RotatingSpriteGameObject
    {
        Vector2 StartScreen;

        public Bird() : base("spr_bird")
        {
            //TODO Check if origin is correct
            origin = new Vector2(sprite.Width, sprite.Height);
            this.Origin = origin;
            StartScreen = new Vector2(FlappyBird.Screen.X / 2, FlappyBird.Screen.Y / 2);           

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.Velocity = Vector2.Zero;
            this.Position = StartScreen;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            this.velocity.Y += 20;
            this.AngularDirection = new Vector2 (100, this.velocity.Y);
        }
    }
}
