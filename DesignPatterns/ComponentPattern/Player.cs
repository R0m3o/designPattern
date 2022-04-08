using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;



namespace DesignPatterns
{
    class Player : Component
    {
        private float speed;

        private int gravity;

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;
            GameObject.Transform.Translate(velocity * Game1.DeltaTime);
        }

        public void Jump(Vector2 force)
        {
            if (force != Vector2.Zero)
            {
                force.Normalize();
            }


            force *= gravity;
            GameObject.Transform.Translate(force * Game1.DeltaTime);
        }

        public override void Awake()
        {
            speed = 100;
            gravity = 1000;

        }
        
        public override void Start()
        {
            SpriteRenderer spriteRenderer = GameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
            spriteRenderer.SetSprite("Sprites/abstract-gd1ebff345_640");
            GameObject.Transform.Position = new Vector2(Game1.Instance.Graphics.PreferredBackBufferWidth / 2, Game1.Instance.Graphics.PreferredBackBufferHeight - spriteRenderer.Sprite.Height / 3);
        }

        public override void Update(GameTime gameTime)
        {
            InputHandler.Instance.Execute(this);
        }

    }
}
