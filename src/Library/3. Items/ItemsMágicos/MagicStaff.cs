using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class MagicStaff: MagicItem
    {

        public MagicStaff(string name, int damage, int protection, int healing, bool magic, bool attackItem): base( name, damage, protection, healing, magic, attackItem)
        {
            this.magic = true;
        }

    }
}