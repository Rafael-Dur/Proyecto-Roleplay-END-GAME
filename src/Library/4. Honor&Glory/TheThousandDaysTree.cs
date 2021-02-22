using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class TheThousandDaysTree: TowerOfTheFallenOnes
    {
        public List<IHero> heroesDerrotados = new List<IHero>();

        public TheThousandDaysTree()
        {
            
        }
        public void Add(IHero heroe)
        {
            heroesDerrotados.Add(heroe);
        }


    }
}