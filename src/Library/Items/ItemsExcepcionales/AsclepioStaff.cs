using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class AsclepioStaff: Item
    {
        public List<MagicItem> ListMagic{get;set;}
        public AsclepioStaff(string name, int damage, int MagicDamage, int protection, int healing, bool attackItem): base(name, damage, protection, healing,attackItem)
        {
            
            ListMagic=new List<MagicItem>();
        }

        public void Combine(MagicItem item)
        {
           ListMagic.Add(item);
        }

        

    }
}