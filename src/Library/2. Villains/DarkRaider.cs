using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DarkRaider: Character, IVillain
    {
        protected int speedMovment {get; set;}

        public DarkRaider(string name, int damage, int health, int healing, int speedMovment,  List<Item> inventary): base (name,damage, health, healing, inventary, false, true)
        {
            this.healing = 0;
            this.hero = false;
            this.speedMovment = speedMovment;
        }
        bool IVillain.DoesItFly()
        {
            return false;
        }

        public void AddItems(Item item)
        {
            if(isItemVillain(item))
            {
                if (item is Gem)
                    {
                        foreach(Item it in inventary)
                        {
                            if(it is DarkSword)
                            {
                                DarkSword darkSword =(DarkSword)it;
                                darkSword.listGems.Add((Gem)item);
                            }
                        }
                    }
                    else{
                        inventary.Add(item);
                    }
            }
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
        public bool isDead()
        {
            return !IsAlive();
        }
    }
}