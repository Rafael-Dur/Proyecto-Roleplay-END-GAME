using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class RegenerativePotion: Item
    {
        public int durationEffect {get; set;}

        public string power {get; set;} /*Descripción de lo que hace el item*/

        public RegenerativePotion(string name, int damage, int protection, int healing, int durationEffect, string power, bool attackItem): base(name, damage, protection, healing, false)
        {
            this.durationEffect = durationEffect;
            this.power = power;
        }
    }
}