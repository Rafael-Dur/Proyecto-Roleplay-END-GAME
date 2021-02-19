using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Boots: Item
    {
        public string Power {get; set;} /*Descripción de lo que hace el item*/

        public Boots(string name, int damage, int protection, string power, bool attackItem): base(name, damage, protection, 0, false)
        {
            this.Power = power;
        }
    }
}