using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Dragon: Character
    {
        protected int fireBreath {get; set;} /* Atributo que intensifica porcentualmente el valor de daño del personaje*/

        protected bool fly {get; set;} /*Si el personaje puede volar, no puede ser atacado con armas cuerpo a cuerpo*/
        public List<Item> hybridInventary = new List<Item>();

        public Dragon(string name, int damage, int health, int healing, int fireBreath,  List<Item> hybridInventary) :base (name,damage, health, healing, new List<Item>(), false)
        {
            this.healing = 0;
            this.hero = false;
            this.fireBreath = fireBreath;
            this.fly = true;
            this.hybridInventary = hybridInventary;

        }
        public void AddItems(Item item)
        {   
            if(isItemVillain(item))
                inventary.Add(item);
        }
        public void AddItems(MagicItem magicItem)
        {
            if(isItemVillain(magicItem))
                hybridInventary.Add(magicItem);
        }

         public new void RemoveItem(Item item)
        {
            inventary.Remove(item);

        }

         public void RemoveMagicItem(MagicItem magicItem)
        {
            inventary.Remove(magicItem);

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