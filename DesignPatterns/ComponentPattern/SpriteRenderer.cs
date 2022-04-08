﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace DesignPatterns
{
    class SpriteRenderer : Component
    {
        public Texture2D Sprite { get; set; }
        public Vector2 Origin { get; set; }

        public override void Start()
        {
            Origin = new Vector2(Sprite.Width / 2, Sprite.Height / 2);
        }

        public void SetSprite(string spriteName)
        {
            Sprite = Game1.Instance.Content.Load<Texture2D>(spriteName);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, GameObject.Transform.Position, null, Color.White, 0, Origin, 1, SpriteEffects.None, 1);
        }
    }
}
