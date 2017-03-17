using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Pipe : SpriteGameObject
    {
        int randomHeight = GameEnvironment.Random.Next(200, 401);

        public Pipe() : base("spr_pipe")
        {
            this.velocity = new Vector2(-300, 0);
            origin = sprite.Center;
            this.Position = new Vector2(700, randomHeight);
        }
    }
}
