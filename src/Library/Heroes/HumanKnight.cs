using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class HumanKnight: Character
    {
        public int stun {get; set;} /*Este atributo impide a los oponentes atacarlo durante un período de tiempo*/

        public  HumanKnight(string name, int damage, int health, int healing, List<Item> inventary, int stun): base( name,damage,health,healing,inventary,hero,villain)
        {
            this.healing = 0;
            this.hero = true;
            this.villain = false;
            this.stun = stun;

        }

        public void AddItems(Item item)
        {
            inventary.Add(item);
        }
    }
}