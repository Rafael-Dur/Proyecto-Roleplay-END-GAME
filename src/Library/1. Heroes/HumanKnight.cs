using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class HumanKnight: Character
    {
        public int stun {get; set;} /*Este atributo impide a los oponentes atacar, curarse y moverse durante un período de tiempo*/

        public  HumanKnight(string name, int damage, int health, int healing, List<Item> inventary, int stun): base( name,damage,health,healing,inventary,true, true)
        {
            this.healing = 0;
            this.hero = true;
            this.stun = stun;

        }

        public void AddItems(Item item)
        {
            if(isItemHero(item))
                inventary.Add(item);
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
    }
}