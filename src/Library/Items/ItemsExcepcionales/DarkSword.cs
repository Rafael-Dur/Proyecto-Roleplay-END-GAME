using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DarkSword: Item
    {
    
        public DarkSword(string name,  int healing, bool attackItem): base(name, 0, 0, healing,attackItem)
        {
           

        }

        public void Combine(Gem gem)
        {
            this.damage = this.damage + gem.damage;
            this.protection = this.protection + gem.protection;
        }
    }
}