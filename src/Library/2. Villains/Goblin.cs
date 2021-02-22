using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Goblin: Character
    {
        public Goblin(string name, int damage, int health, int healing, List<Item> inventary): base (name,damage, health, healing, new List<Item>(), false, true)
        {
            this.healing = 0;
            this.hero = false;
        }
        
        public void StealItem(Character character, Item item)
        {
            character.RemoveItem(item);
            this.inventary.Add(item);

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