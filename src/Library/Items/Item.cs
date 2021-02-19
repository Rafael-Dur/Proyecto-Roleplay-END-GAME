using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Item
    {
        public string name {get; set;}

        public int damage {get; set;}

        public int protection {get; set;}

        public int healing {get; set;}

        public bool attackItem {get; set;}

        public Item(string name, int damage, int protection, int healing, bool attackItem)
        {
            this.name = name;
            this.damage = damage;
            this.protection = protection;
            this.healing = healing;
            this.attackItem = attackItem;
        }

        public virtual int Attack()
        {
            if(!attackItem)
            {
                return 0;
            }
            else{
                return damage;
            }
        }

    }
}