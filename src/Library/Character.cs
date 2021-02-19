using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Character
    {
        protected string name{get; set;}

        protected int damage {get; set;}

        protected int health {get; set;}

        protected int healing {get; set;}

        protected List<Item> inventary = new List<Item>();

        protected int vp {get; set;}

        protected bool hero {get; set;}

        public Character(string name, int damage, int health, int healing, List<Item> inventary,  bool hero)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.vp = 0;
            this.hero = hero;

        }

        public void Attack(Character character)
        {
            int newHealth = character.health - this.damage;
            character.health=newHealth;
            if(newHealth<=0)
            {
                vp=vp+10;
            }
        }

        public void Cure(Character character)
        {
            int newHealth = character.health + this.healing;
            character.health = newHealth;

        }

        public void AddItem(Item item)
        {
            inventary.Add(item);
        }

        public void RemoveItem(Item item)
        {
            inventary.Remove(item);
        }
    }
}