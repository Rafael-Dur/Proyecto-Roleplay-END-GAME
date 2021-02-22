using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Character
    {
        public string name{get; set;}

        public int damage {get; set;}

        public int health {get; set;}

        public int healing {get; set;}

        public List<Item> inventary = new List<Item>();

        public int vp {get; set;}

        public bool hero {get; set;}

        public bool isAlive {get; set;}

        public Character(string name, int damage, int health, int healing, List<Item> inventary,  bool hero, bool isAlive)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.vp = 0;
            this.hero = hero;
            this.isAlive = isAlive;
        }

        public void Attack(Character character)
        {
            int newHealth = character.health - this.damage;
            character.health=newHealth;
            if(character.health<=0)
            {
                this.vp=vp + character.vp;
                this.health += this.health + 50;
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

        public bool IsAlive()
        {
            bool isAlive=true;
            if(this.health <= 0)
            {
                isAlive = false;
            }
            return isAlive;
        }
    }
}