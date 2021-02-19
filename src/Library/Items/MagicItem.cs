using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class MagicItem: Item
    {
        protected bool magic = true;

        public MagicItem(string name, int damage, int protection, int healing, bool magic): base( name,damage,protection,healing)
        {
            this.magic = magic;

        }

    }
}