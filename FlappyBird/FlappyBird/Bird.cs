using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Bird : RotatingSpriteGameObject
    {
        public Bird() : base("spr_bird")
        {
            //TODO Check if origin is correct
            origin = new Vector2(sprite.Width, sprite.Height);
            this.Origin = origin;
            Vector2 StartScreen = new Vector2(FlappyBird.Screen.X / 2, FlappyBird.Screen.Y / 2);

            this.Position = StartScreen;
        }
    }
}
