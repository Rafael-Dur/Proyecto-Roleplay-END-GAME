using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Encounters: IScenary
    {

        public List<IHero> listaDeHeroes = new List<IHero>();
        public List<IVillain> listaDeVillanos = new List<IVillain>();

        public Encounters(List<IHero> listaDeHeroes, List<IVillain> listaDeVillanos)
        {
            this.listaDeHeroes = listaDeHeroes;
            this.listaDeVillanos = listaDeVillanos;
        }
        
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


        public string CombatEncounter()
        {
            while((listaDeHeroes.Count) > 0 && (listaDeVillanos.Count) > 0)
            {
                int i =0;
                foreach(IVillain villano in listaDeVillanos)
                {
                    Character heroe=(Character)listaDeHeroes[i];
                    ((Character)villano).Attack(heroe);
                    if(((Character)heroe).IsAlive() != true)
                    {
                        listaDeHeroes.Remove(listaDeHeroes[i]);
                    }

                    i++;
                    if(listaDeHeroes.Count==i)
                    {
                        i=0;
                    }
                }

                foreach(IHero heroe in listaDeHeroes)
                {
                    foreach(IVillain villano in listaDeVillanos)
                    {
                            ((Character)heroe).Attack((Character)villano);
                            if(((Character)villano).IsAlive() != true)
                            {
                                listaDeVillanos.Remove(villano);
                            }
                    }   
                }
                
            }
            if(listaDeHeroes.Count>0)
            {
                return "win villain";
            }
            else{
                return "win heroe";
            }
        }
    }
}