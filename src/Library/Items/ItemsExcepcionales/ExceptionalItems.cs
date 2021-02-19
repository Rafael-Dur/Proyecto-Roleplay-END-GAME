using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class ExceptionalItems: Item
    {
        
        public ExceptionalItems(string name, int damage, int protection, int healing): base(name, damage, protection, healing)
        {
            this.name = name;
            this.damage = damage;
            this.protection = protection;
            this.healing = healing;

        }

    }
}