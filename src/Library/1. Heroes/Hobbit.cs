using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Hobbit: Character,IHero
    {
        public int invisivility {get; set;} /*Al no ser visto, el personaje no puede ser atacado mientras dure el efecto (en un período de tiempo)*/

        public  Hobbit(string name, int damage, int health, int healing, List<Item> inventary, int invisivility): base( name,damage,health,healing,inventary,true, true)
        {
            this.healing = 0;
            this.hero = true;
            this.invisivility = invisivility;

        }

        public void AddItems(Item item)
        {
            if(isItemHero(item))
                inventary.Add(item);
        
        }

        public new void RemoveItem(Item item)
        {
            inventary.Remove(item);

        }

        public bool isItemHero(Item item)
        {
            if(item is IVillain)
            {
                return false;
            }
            else{
                return true;
            }
        }
    }
}