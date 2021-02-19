using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Orc: Character
    {
        protected int strenght {get; set;} /*Atributo que incrementa porcentualmente el daño inflingido*/

        public Orc(string name, int damage, int health, int healing, int strenght,  List<Item> inventary): base (name,damage, health, healing, inventary, hero, villain)
        {
            this.healing = 0;
            this.hero = false;
            this.villain = true;
            this.strenght = strenght;

        }
        
        public void AddItems(Item item)
        {
            inventary.Add(item);
        }
    }
}