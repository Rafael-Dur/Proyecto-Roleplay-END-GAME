using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DarkRaider: Character
    {
        protected int speedMovment {get; set;}

        public DarkRaider(string name, int damage, int health, int healing, int speedMovment,  List<items> inventary): base (name,damage, health, healing, inventary, hero, villain)
        {
            this.healing = 0;
            this.hero = false;
            this.villain = true;
            this.speedMovment = speedMovment;

        }

        public void AddItems(Item item)
        {
            inventary.Add(item);
        }
    }
}