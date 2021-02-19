using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Dwarf: Character
    {
        public int resistance {get; set;} /*Atributo que reduce porcentualmente el daño recibido*/

        public  Dwarf(string name, int damage, int health, int healing, List<items> inventary, int resistance): base( name,damage,health,healing,inventary,hero,villain)
        {
            this.healing = 0;
            this.hero = true;
            this.villain = false;
            this.resistance = resistance;

        }

        public void AddItems(Item item)
        {
            inventary.Add(item);
        }
    }
}