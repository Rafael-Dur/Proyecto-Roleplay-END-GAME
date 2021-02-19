using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Encounters
    {
        public void ExchangeEncounter(Character originCharacter, Character recieverCharacter,Item item)
        {
            originCharacter.RemoveItem(item);
            recieverCharacter.AddItem(item);
        }
        public void ExchangeEncounter(Wizard originCharacter, Wizard recieverCharacter,Spell item)
        {
            originCharacter.RemoveItem(item);
            recieverCharacter.AddItem(item);
        }
    }
}