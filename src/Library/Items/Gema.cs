using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Gema: Item
    {
    
        public Gema(string name, int damage, int protection, int healing): base(name, damage, protection, healing)
        {
            this.name = name;
            this.damage = 0;
            this.protection = 0;
            this.healing = 0;

        }

    }
}