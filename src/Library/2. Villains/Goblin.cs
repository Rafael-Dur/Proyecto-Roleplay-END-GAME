using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Goblin: Character, IVillain
    {
        public Goblin(string name, int damage, int health, int healing, List<Item> inventary): base (name,damage, health, healing, new List<Item>(), false, true)
        {
            this.healing = 0;
            this.hero = false;
        }
        
        public void StealItem(Character character)
        {
            Random random=new Random();
            int posicion=random.Next(0,inventary.Count);
            Item item=character.inventary[posicion];
            character.RemoveItem(item);
            this.AddItems(item);
        }
        public override void Attack(Character character)
        {
            Item item=character.inventary[0];
            this.StealItem(character);
            int newHealth = character.health - this.damage;
            character.health=newHealth;
            if(character.health<=0)
            {
                this.vp=vp + character.vp;
                this.health += this.health + 50;
                character.health=0;
            }
        }
         bool IVillain.DoesItFly()
         {
             return false;
         }
        public void AddItems(Item item)
        {
            if(isItemVillain(item))
            {
                if (item is Gem)
                    {
                        foreach(Item it in inventary)
                        {
                            if(it is DarkSword)
                            {
                                DarkSword darkSword =(DarkSword)it;
                                darkSword.listGems.Add((Gem)item);
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
        public bool isDead()
        {
            return !IsAlive();
        }
    }
}