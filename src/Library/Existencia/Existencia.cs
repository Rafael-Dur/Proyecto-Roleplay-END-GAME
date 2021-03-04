using System;
using System.Collections.Generic;
using RolePlayEndGame;
using System.IO;

namespace RolePlayEndGame
{
    public class Existencia
    {
        public static Encounters CreateCharactersAndItems(String path)
        {
            
            StreamReader sr = new StreamReader(path);
            List<IHero>listHeroe=new List<IHero>();
            string line = sr.ReadLine();

            while(line!=null)
            {
                string[] part=line.Split(",");
                line = sr.ReadLine();

                if(part[0] == "dwarf")
                {
                    string name=part[1];
                    int damage=Convert.ToInt32(part[2]);
                    int health = Convert.ToInt32(part[3]);
                    int healing = Convert.ToInt32(part[4]);
                    List<Item> dwarfInventary = new List<Item>();
                    int resistance = Convert.ToInt32(part[6]);
                    Dwarf dwarf=new Dwarf(name, damage, health, healing, dwarfInventary, resistance);
                    listHeroe.Add(dwarf);
                }

                if(part[0] == "elf")
                {
                    string name=part[1];
                    int damage=Convert.ToInt32(part[2]);
                    int health = Convert.ToInt32(part[3]);
                    int healing = Convert.ToInt32(part[4]);
                    List<Item> elfInventary = new List<Item>();
                    int speedMovment = Convert.ToInt32(part[6]);
                    Elf elf =new Elf(name, damage, health, healing, elfInventary, speedMovment);
                    listHeroe.Add(elf);
                }

                
            }

            Encounters encounters=new Encounters(listHeroe,new List<IVillain>());
            return encounters;
        }
    }
}