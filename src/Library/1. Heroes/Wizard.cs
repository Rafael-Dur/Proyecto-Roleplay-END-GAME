using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Wizard: Character, IHero
    {
        public static WisdomBook wisdm {get;set;}
        protected int MagicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/
        public List<MagicItem> magicInventary = new List<MagicItem>();
        public SpellsBook spellsBook{get;set;}

        public static WisdomBook wisdomBook {get; set;} = new WisdomBook();

        public  Wizard(string name, int damage, int health, int healing, int MagicDamage, List<MagicItem> magicInventary): base( name, damage, health, healing, new List<Item>(),true, true)
        {
            this.hero = true;
            this.MagicDamage = MagicDamage;
            this.magicInventary = magicInventary;
            spellsBook = new SpellsBook();
            
        }
        public override void Attack(Character character)
        {
            int newHealth = character.health - (this.damage + this.MagicDamage);
            character.health=newHealth;
            if(character.health<=0)
            {
                this.vp=vp + character.vp;
                this.health += this.health + 50;
                character.health=0;
            }
        }

        public void AddItems(Spell spell)
        {
            spellsBook.Combine(spell);
        }

        public void AddItems(MagicItem magicItem)
        {
            if(isItemHero(magicItem))
                magicInventary.Add(magicItem);
        }

         public void RemoveMagicItem(MagicItem magicItem)
        {
            inventary.Remove(magicItem);
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