using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class SpellsBook: MagicItem
    {
        public List<Spell> listOfSpells = new List<Spell>();

        public SpellsBook():base("Libro de Hechizos", 0, 0,0, true,false)
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