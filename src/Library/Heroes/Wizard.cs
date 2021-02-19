using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Wizard: Character
    {
        protected int MagicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/
        public List<magicItems> magicInventary = new List();

        public  Wizard(string name, int damage, int health, int healing,int MagicDamage, List<magicItems> magicinventary): base( name, damage, health, healing, hero, villain)
        {
            this.hero = true;
            this.villain = false;
            this.MagicDamage = MagicDamage;
            this.magicInventary = magicInventary;
        }

        public void AddItems(Item magicItem)
        {
            magicInventary.Add(magicItem);
        }
    }
}