using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Hobbit: Character,IHero
    {
        public int invisivility {get; set;} /*Al no ser visto, el personaje no puede ser atacado mientras dure el efecto (en un período de tiempo)*/
        public DateTime Protecter {get;set;}
        public bool isInvisible{get;set;}
        public  Hobbit(string name, int damage, int health, int healing, List<Item> inventary, int invisivility): base( name, damage, health, healing, inventary, true, true)
        {
            this.healing = 0;
            this.hero = true;
            this.invisivility = invisivility;
            isInvisible=false;
        }

       public void AddItems(Item item)
        {
            if(isItemHero(item))
                {
                    if (item is MagicItem)
                    {
                        foreach(Item it in inventary)
                        {
                            if(it is AsclepioStaff)
                            {
                                AsclepioStaff asclepio=(AsclepioStaff)it;
                                asclepio.ListMagic.Add((MagicItem)item);
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