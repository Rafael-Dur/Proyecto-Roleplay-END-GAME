using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Orc: Character, IVillain
    {
        protected int strenght {get; set;} /*Atributo que incrementa porcentualmente el daño inflingido*/

        public Orc(string name, int damage, int health, int healing, int strenght,  List<Item> inventary): base (name,damage, health, healing, new List<Item>(), false, true)
        {
            this.healing = 0;
            this.hero = false;
            this.strenght = strenght;

        }

        public override void Attack(Character character)
        {
            int newHealth = character.health - (this.damage*this.strenght);
            if(character is Dwarf)
            {
                newHealth = (character.health+((Dwarf)character).resistance)  - (this.damage*this.strenght);
                
            }
            if(character is Hobbit)
                {
                    if(((Hobbit)character).isInvisible)
                    {
                       TimeSpan tiempo=DateTime.Now- ((Hobbit)character).Protecter;
                       if(tiempo.Seconds>((Hobbit)character).invisivility)
                       {
                            newHealth = character.health - (this.damage + this.strenght);
                            ((Hobbit)character).isInvisible=false;
                       }
                    }
                    else
                    {
                        Random random = new Random();
                        int booleano = random.Next(0,1);
                        
                        if(booleano == 1)
                        {
                            ((Hobbit)character).isInvisible=true;    
                        }
                        else
                        {
                            newHealth = character.health - (this.damage + this.strenght);
                        }
                    }
                }
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