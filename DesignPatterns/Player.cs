using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;



namespace DesignPatterns
{
    class Player
    {
        private Texture2D sprite;

        private float speed;

        private Vector2 position;

        private Vector2 origin;

        private InputHandler inputHandler;

        private int gravity;


        public Player(Vector2 startPosition)
        {
            this.inputHandler = new InputHandler();
            this.position = startPosition;
            speed = 100;
            gravity = 1000;
        }

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;
            position += velocity * Game1.DeltaTime;
        }

        public void Jump(Vector2 force)
        {
            if (force != Vector2.Zero)
            {
                force.Normalize();
            }

           
            force *= gravity;
            position += force * Game1.DeltaTime;

        }

        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Sprites/abstract-gd1ebff345_640");
            origin = (new Vector2(sprite.Width / 2, sprite.Height / 2));
            position.Y -= sprite.Height / 3;
        }

        public void Update(GameTime gameTime)
        {
            inputHandler.Execute(this);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 1);
        }
    }
}
