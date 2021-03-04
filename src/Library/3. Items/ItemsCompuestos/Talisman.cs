using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Talisman: ComponedItems
    {
        public Talisman(string name, int damage, int protection, int healing, int durationEffect, string power, bool attackItem): base(name, damage, protection, healing, false)
        {

        }

        public void ComponeAnItem(Character character, RegenerativePotion rp1 , RegenerativePotion rp2)
        {
            if(character.inventary.Count >= 2)
            {
                Talisman talisman = new Talisman("...", 5, 70, 25, 120, "Baluarte", false);
                character.RemoveItem(rp1);
                character.RemoveItem(rp2);
            }
        }

    }
}