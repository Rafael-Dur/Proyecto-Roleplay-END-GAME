using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class FuryPotion: Item
    {
        public int damageBoost {get; set;}

        public int durationEffect {get; set;}

        public string power {get; set;} /*Descripción de lo que hace el item*/

        public FuryPotion(string name, int damage, int protection, int healing, int damageBoost, int durationEffect, string power, bool attackItem): base(name, damage, protection, healing, false)
        {
            this.damageBoost = damageBoost;
            this.durationEffect = durationEffect;
            this.power = power;

        }
    }
}