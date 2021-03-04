using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Dwarf: Character,IHero
    {
        public int resistance {get; set;} /*Atributo que reduce porcentualmente el daño recibido*/

        public  Dwarf(string name, int damage, int health, int healing, List<Item> inventary, int resistance): base( name,damage,health,healing,inventary,true, true)
        {
            this.healing = 0;
            this.hero = true;
            this.resistance = resistance;

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