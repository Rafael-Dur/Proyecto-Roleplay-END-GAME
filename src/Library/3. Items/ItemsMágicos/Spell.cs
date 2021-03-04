using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Spell: MagicItem
    {
    
        public Spell(string name, int damage, int protection, int healing, bool magic, bool attackItem): base(name, damage, protection, healing, true, attackItem)
        {
           
        }

    }
}