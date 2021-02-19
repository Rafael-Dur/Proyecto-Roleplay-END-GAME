using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class ComponedItems: Item
    {
        public List<Item> composition = new List<Item>();
        public ComponedItems(string name, int damage, int protection, int healing, List<Item> composition): base(name, damage, protection, healing)
        {
            this.composition = composition;
        }

        public void ComponeAnItem(Item item)
        {
            composition.Add(item);
            if(item.attackItem == true)
            {
                damage += damage*10;
            }

            else(item.defensiveItem == true);
            {
                protection += protection*10;
            }
        }
    }
}