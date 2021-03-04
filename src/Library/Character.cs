using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public abstract class Character
    {
        public string name{get; set;}

        public int damage {get; set;}

        public virtual int health {get; set;}

        public int healing {get; set;}

        public List<Item> inventary;

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
            this.inventary=inventary;
        }

        private void AttackAux(Character character)
        {
             int newHealth = character.health - this.damage;
                character.health=newHealth;
                if(character.health<=0)
                {
                    this.vp=vp + character.vp;
                    this.health += this.health + 50;
                    character.health=0;
                }
        }
        public virtual void Attack(Character character)
        {
            
            if(character is IVillain)
            {
                if(((IVillain)character).DoesItFly())
                {
                    bool play=false;
                    foreach(Item item in this.inventary)
                    {
                        if(item is Bow)
                        {
                            AttackAux(character);
                            play=true;
                        }
                        
                    }
                    if(!play)
                    {
                        throw new Exception("Tu personaje no puede atacar enemigos voladores, porque no cuenta con armas a distancia");
                    }
                    
                }
                else
                {
                    AttackAux(character);
                }
            }

            else
            {
                if(character is Dwarf)
                {
                    int newHealth = (character.health+((Dwarf)character).resistance)  - this.damage;
                    character.health=newHealth;
                    if(character.health<=0)
                    {
                        this.vp=vp + character.vp;
                        this.health += this.health + 50;
                        character.health=0;
                    }
                }
            
                else
                {
                if(character is Hobbit)
                {
                    if(((Hobbit)character).isInvisible)
                    {
                       TimeSpan tiempo=DateTime.Now- ((Hobbit)character).Protecter;
                       if(tiempo.Seconds>((Hobbit)character).invisivility)
                       {
                            AttackAux(character);
                            ((Hobbit)character).isInvisible=false;
                       }
                    }
                    else
                    {
                        Random random = new Random();
                        //int booleano = random.Next(0,1);
                        int booleano=0;
                        if(booleano == 1)
                        {
                            ((Hobbit)character).isInvisible=true;    
                        }
                        else
                        {
                            AttackAux(character);
                        }
                    }
                }
                
                else
                {
                    AttackAux(character);

                }
            }
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