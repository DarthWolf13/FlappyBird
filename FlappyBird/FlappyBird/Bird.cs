using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            origin = sprite.Center;
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

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
                this.velocity = new Vector2(0, -450);
        }
    }
}
