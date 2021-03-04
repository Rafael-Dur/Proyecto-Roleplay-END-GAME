using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DarkSword: Item
    {
        public List<Gem> listGems = new List<Gem>();
        public DarkSword(string name, int damage, int protection, int healing, bool attackItem, List<Gem> listGems): base(name, 0, 0, healing,attackItem)
        {
           this.listGems = listGems;
        }

        public void Combine(Character character, Gem gem)
        {
            this.damage = this.damage + gem.damage;
            this.protection = this.protection + gem.protection;
            listGems.Add(gem);
            DarkSword darkSword = new DarkSword("Espada de los oscuros", damage, protection, 0, true, listGems);
            character.RemoveItem(gem);
        }
    }
}