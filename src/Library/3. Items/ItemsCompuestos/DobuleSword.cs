using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class DoubleSword: ComponedItems
    {
        public List<Sword> itemsNecesarios = new List<Sword>();
        public DoubleSword(string name, int damage, int protection, string power, bool attackItem): base(name, damage, protection, 0, attackItem)
        {

        }

        public void ComponeAnItem(Character character, Sword sword1,Sword sword2)
        {
            if(character.inventary.Count >= 2)
            {
                DoubleSword doubleSword1 = new DoubleSword("Ragnarok", 50, 20, "Ataque giratorio", true);
                character.RemoveItem(sword1);
                character.RemoveItem(sword2);
            }
        }
    }
}