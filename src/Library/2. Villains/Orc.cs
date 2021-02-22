using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Orc: Character
    {
        protected int strenght {get; set;} /*Atributo que incrementa porcentualmente el daño inflingido*/

        public Orc(string name, int damage, int health, int healing, int strenght,  List<Item> inventary): base (name,damage, health, healing, new List<Item>(), false, true)
        {
            this.healing = 0;
            this.hero = false;
            this.strenght = strenght;

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