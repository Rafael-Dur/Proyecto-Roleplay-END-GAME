using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class ComponedItems: Item
    {
        public ComponedItems(string name, int damage, int protection, int healing, bool attackItem): base(name, damage, protection, healing, attackItem)
        {

        }
    }
}