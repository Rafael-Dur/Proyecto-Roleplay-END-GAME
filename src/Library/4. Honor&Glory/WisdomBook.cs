using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public  class WisdomBook
    {
        public List<Character> listOfDefeats = new List<Character>();

        public WisdomBook()
        {

        }

        public void Register(Character character)
        {
            if(character.IsAlive())
            {
                listOfDefeats.Add(character);
            }
        }
    }
}