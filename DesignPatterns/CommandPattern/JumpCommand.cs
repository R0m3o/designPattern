using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;


namespace DesignPatterns
{
    class JumpCommand : ICommand
    {
        private Vector2 force;

        public JumpCommand(Vector2 force)
        {
            this.force = force;
        }

        public void Execute(Player player)
        {
            
            player.Jump(force);
            
        }
    }
}
