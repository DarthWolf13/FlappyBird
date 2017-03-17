﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class TitleScreenState : GameObjectList
    {
        private TextGameObject text;

        public TitleScreenState()
        {
            this.text = new TextGameObject("GameFont");
            this.text.Text = "Flappy Bird";
            this.text.Position = new Vector2((FlappyBird.Screen.X / 2) - (this.text.Size.X / 2), (FlappyBird.Screen.Y / 2) - (this.text.Size.Y / 2));

            this.Add(text);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                FlappyBird.GameStateManager.SwitchTo("PlayingState");
            }
        }
    }
}
