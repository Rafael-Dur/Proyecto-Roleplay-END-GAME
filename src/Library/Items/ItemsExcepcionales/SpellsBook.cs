using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class SpellsBook: MagicItem
    {
        public List<Spell> listOfSpells = new List<Spell>();

        public SpellsBook()
        {
        }

        public SpellsBook(string name, int damage, int protection, int healing, bool magic, bool attackItem): base(name, damage, protection, healing,true, attackItem)
        {
           
        }

        public void Combine(Spell spell)
        {
            listOfSpells.Add(spell);
            this.damage += spell.damage;
            this.protection += spell.protection;
            this.healing += spell.healing;
        }
    }
}