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

        public Dragon(string name, int damage, int health, int healing, int fireBreath,  List<Item> hybridInventary) :base (name,damage, health, healing, hero, villain)
        {
            this.healing = 0;
            this.hero = false;
            this.villain = true;
            this.fireBreath = fireBreath;
            this.fly = true;
            this.hybridInventary = hybridInventary;

        }
        public void AddItems(Item item)
        {
            inventary.Add(item);
        }
        public void AddItems(MagicItem item)
        {
            hybridInventary.Add(item);
        }
    }
}