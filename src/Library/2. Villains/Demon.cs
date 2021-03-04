using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Demon: Character, IVillain
    {
        protected int magicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/

        protected bool fly {get; set;}
        public List<MagicItem> magicInventary = new List<MagicItem>();

        public Demon(string name, int damage, int health, int healing, int magicDamage,  List<MagicItem> magicInventary): base (name,damage, health, healing, new List<Item>(), false, true)
        {
            this.healing = 0;
            this.hero = false;
            this.fly = true;
            this.magicDamage = magicDamage;
            this.magicInventary = magicInventary;
        }

        public override void Attack(Character character)
        {
            int newHealth = character.health;
            if(character is Dwarf)
                {
                    newHealth = (character.health+((Dwarf)character).resistance)  - (this.damage + this.magicDamage);
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
                                    newHealth -= (this.damage + this.magicDamage);
                                    character.health = newHealth;
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
                                    newHealth -= (this.damage + this.magicDamage);
                                    character.health = newHealth;
                                }
                            }
                    }
                    newHealth -= (this.damage + this.magicDamage);
                    character.health=newHealth;
                    if(character.health<=0)
                    {
                        this.vp=vp + character.vp;
                        this.health += this.health + 50;
                        character.health=0;
                    }
                }
        }

        public void AddItems(MagicItem magicItem)
        {
            if(isItemVillain(magicItem))
                magicInventary.Add(magicItem);
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
        public bool isDead()
        {
            return !IsAlive();
        }

        bool IVillain.isItemVillain(Item item)
        {
            throw new NotImplementedException();
        }

        bool IVillain.DoesItFly()
        {
            return true;
        }

        bool IVillain.isDead()
        {
            throw new NotImplementedException();
        }
    }
}