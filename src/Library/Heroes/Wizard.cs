using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Wizard: Character
    {
        protected int MagicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/
        public List<MagicItem> magicInventary = new List<MagicItem>();

        public  Wizard(string name, int damage, int health, int healing,int MagicDamage, List<MagicItem> magicinventary): base( name, damage, health, healing, hero, villain)
        {
            this.hero = true;
            this.villain = false;
            this.MagicDamage = MagicDamage;
            this.magicInventary = magicInventary;
        }

        public void AddItems(MagicItem magicItem)
        {
            magicInventary.Add(magicItem);
        }
    }
}