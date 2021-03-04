using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Elf: Character, IHero
    {
        public int speedMovment {get; set;}

        public List<Item> hybridInventary = new List<Item>();

        public  Elf(string name, int damage, int health, int healing, List<Item> hybridInventary, int speedMovment): base( name, damage, health, healing,new List<Item>(), true, true)
        {
            this.hero = true;
            this.speedMovment = speedMovment;
            this.hybridInventary = hybridInventary;

        }

        public void AddItems(Item item)
        {        
            if(isItemHero(item) && !(item is AsclepioStaff))
                hybridInventary.Add(item);
        }

        public void AddItems(MagicItem item)
        {
            if(isItemHero(item))
                hybridInventary.Add(item);
        }

         public new void RemoveItem(Item item)
        {
            inventary.Remove(item);

        }

         public void RemoveMagicItem(MagicItem magicItem)
        {
            inventary.Remove(magicItem);

        }

        public bool isItemHero(Item item)
        {
            if(item is IVillain)
            {
                return false;
            }
            else{
                return true;
            }
        }
        
        public bool isDead()
        {
            return !IsAlive();
        }
    }
}