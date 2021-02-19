using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Wizard: Character
    {
        protected int MagicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/
        public List<MagicItem> magicInventary = new List<MagicItem>();
        public SpellsBook Book{get;set;}
        public  Wizard(string name, int damage, int health, int healing,int MagicDamage, List<MagicItem> magicInventary): base( name, damage, health, healing, new List<Item>(),true)
        {
            this.hero = true;
            this.MagicDamage = MagicDamage;
            this.magicInventary = magicInventary;
            Book = new SpellsBook();

        }

        public void AddItems(Spell spell)
        {
            Book.Combine(spell);
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
    }
}