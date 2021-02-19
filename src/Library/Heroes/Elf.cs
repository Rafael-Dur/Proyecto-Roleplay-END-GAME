using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Elf: Character
    {
        public int speedMovment {get; set;}

        public List<Item> hybridInventary = new List<Item>();

        public  Elf(string name, int damage, int health, int healing, List<Item> hybridinventary, int speedMovment): base( name, damage, health, healing, hero, villain)
        {
            this.hero = true;
            this.villain = false;
            this.speedMovment = speedMovment;
            this.hybridInventary = hybridInventary;

        }

        public void AddItems(Item item)
        {
            hybridInventary.Add(item);
        }
        public void AddItems(MagicItem item)
        {
            hybridInventary.Add(item);
        }

    }
}