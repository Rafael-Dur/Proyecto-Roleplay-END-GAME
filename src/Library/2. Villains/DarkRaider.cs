using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DarkRaider: Character
    {
        protected int speedMovment {get; set;}

        public DarkRaider(string name, int damage, int health, int healing, int speedMovment,  List<Item> inventary): base (name,damage, health, healing, inventary, false, true)
        {
            this.healing = 0;
            this.hero = false;
            this.speedMovment = speedMovment;

        }

        public void AddItems(Item item)
        {
            if(isItemVillain(item))
                inventary.Add(item);
        }

         public new void RemoveItem(Item item)
        {
            inventary.Remove(item);

        }
        public bool isItemVillain(Item item)
        {
            if(item is IHero)
            {
                return false;
            }
            else{
                return true;
            }
        }
    }
}