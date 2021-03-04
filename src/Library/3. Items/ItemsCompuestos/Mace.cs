using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Mace: ComponedItems
    {
        public Mace(string name, int damage, int protection, string power, bool attackItem): base(name, damage, protection, 0, attackItem)
        {

        }

        public void ComponeAnItem(Character character, Axe axe1, Axe axe2)
        {
            if(character.inventary.Count >= 2)
            {
                Mace mace = new Mace("Destroyer", 70, 20, "Destruir escudos", true);
                character.RemoveItem(axe1);
                character.RemoveItem(axe2);
            }
        }

    }
}