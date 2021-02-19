using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Gem: Item
    {
        public Gem(string name, int damage, int protection, int healing, bool attackItem): base(name, damage, protection, healing,attackItem)
        {
           
        }
        public override int Attack()
        {
            return 0;
        }
    }
}