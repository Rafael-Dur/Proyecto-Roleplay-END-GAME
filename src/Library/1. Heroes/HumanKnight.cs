using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class HumanKnight: Character, IHero
    {

        public  HumanKnight(string name, int damage, int health, int healing, List<Item> inventary): base( name,damage,health,healing,inventary,true, true)
        {
            this.healing = 0;
            this.hero = true;

        }

        public override void Attack(Character character)
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
       public void AddItems(Item item)
        {
            if(isItemHero(item))
                {
                    if (item is MagicItem)
                    {
                        foreach(Item it in inventary)
                        {
                            if(it is AsclepioStaff)
                            {
                                AsclepioStaff asclepio=(AsclepioStaff)it;
                                asclepio.ListMagic.Add((MagicItem)item);
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

        public bool isItemHero(Item item)
        {
            if(item is IVillain)
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