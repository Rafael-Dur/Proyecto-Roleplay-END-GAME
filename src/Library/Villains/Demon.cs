using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Demon: Character
    {
        protected int MagicDamage {get; set;} /*Se inflinge daño sin importar si el enemigo lleva una armadura o item defensivo*/

        protected bool fly {get; set;}
        public List<MagicItem> magicInventary = new List<MagicItem>();

        public Demon(string name, int damage, int health, int healing, int MagicDamage,  List<MagicItem> magicInventary): base (name,damage, health, healing, inventary, hero, villain)
        {
            this.healing = 0;
            this.hero = false;
            this.villain = true;
            this.fly = true;
            this.MagicDamage = MagicDamage;
            this.magicInventary = magicInventary;
        }
        public void AddItems(MagicItem magicItem)
        {
            magicInventary.Add(magicItem);
        }
    }
}