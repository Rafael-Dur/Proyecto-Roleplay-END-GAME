using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class EternalStone: TowerOfTheFallenOnes
    {

        public int villanosDerrotados {get; set;}
        public EternalStone()
        {

        }

        public void AddToAccount(IVillain villano)
        {
            if(villano.isDead())
            {
                villanosDerrotados += 1;
            }
        }
    }
}