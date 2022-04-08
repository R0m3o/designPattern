using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace DesignPatterns
{
    class InputHandler
    {
        private Dictionary<Keys, ICommand> keybinds = new Dictionary<Keys, ICommand>();

        public InputHandler()
        {
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(1, 0)));
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(-1, 0)));
            keybinds.Add(Keys.Space, new JumpCommand(new Vector2(0 , -1)));

        }
        public void Execute(Player player)
        {
            KeyboardState keyState = Keyboard.GetState();

            foreach (Keys key in keybinds.Keys)
            {
                if (keyState.IsKeyDown(key))
                {
                    keybinds[key].Execute(player);
                }
            }
        }
    }
}
