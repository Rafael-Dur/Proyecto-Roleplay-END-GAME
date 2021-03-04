using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public class Program
    {
    
        static void Main(string[] args)
        {

            Encounters encounters=Existencia.CreateCharactersAndItems("c://_____");
            encounters.CombatEncounter();


        List<Item> inventary1 = new List<Item>();
        List<Item> inventary2 = new List<Item>();
        List<Item> inventary3 = new List<Item>();
        List<Item> inventary4 = new List<Item>();
        List<Item> inventary5 = new List<Item>();
        List<Item> inventary6 = new List<Item>();

        List<Item> hybridInventary1 = new List<Item>();
        List<Item> hybridInventary2 = new List<Item>();

        List<MagicItem> magicInventary1 = new List<MagicItem>();
        List<MagicItem> magicInventary2 = new List<MagicItem>();


        Axe axe1 = new Axe("Executioner", 25, 0, "Golpes demoledores", true);
        Axe axe2 = new Axe("Hunter Axe", 20, 5, "Otorga algo de defensa", true);
        Sword sword1 = new Sword("Excalivur", 30, 0, "Corte profundo", true);
        Sword sword2 = new Sword("Long Sword", 40, 10, "Ataque a más distancia", true);
        Sword sword3 = new Sword("Dagger", 20, 0, "Un arma ligera que no causa mucho daño", true);
        Bow bow1 = new Bow("Long Bow", 15, 0, "Ataque de largo alcance", true);
        Helmet helmet1 = new Helmet("Iron Helmet", 0, 100, "Protección para la cabeza", false);
        Chestplate chestplate1 = new Chestplate("Iron Chestplate", 0, 100, "Protección para el pecho", false);
        Leggins leggins1 = new Leggins("Iron Leggins", 0, 100, "Protección para las piernas", false);
        Boots boots1 = new Boots("Iron Boots", 0, 100, "Añaden protección para los pies", false);
        Helmet helmet2 = new Helmet("Golden Helmet", 0, 200, "Añade más protección a la cabeza", false);
        Chestplate chestplate2 = new Chestplate("Golden Chestplate", 0, 200, "Añade más protección al pecho", false);
        Leggins leggins2 = new Leggins("Golden Leggins", 0, 200, "Añade más protección al pecho", false);
        Boots boots2 = new Boots("Golden Boots", 0, 200, "Añaden más protección a los pies", false);


        Dwarf dwarf1 = new Dwarf("Thorin", 40, 250, 0, inventary1, 20);
        dwarf1.AddItems(axe1);
        Elf elf1 = new Elf("Galardiel", 35, 270, 20, hybridInventary1, 40);
        Hobbit hobbit1 = new Hobbit("Bilbo", 20, 200, 0, inventary2, 5);
        HumanKnight human1 = new HumanKnight("Aragorn", 30, 300, 0, inventary3);
        Wizard wizard1 = new Wizard("Gandalf", 25, 280, 30, 30, magicInventary1);


        DarkRaider dr1 = new DarkRaider("El Ginete Negro", 35, 500, 0, 50, inventary4);
        Demon demon1 = new Demon("Asmoudeus", 30, 280, 20, 30, magicInventary2);
        Dragon dragon1 = new Dragon("Smaug", 100, 500, 0, 5, hybridInventary2);
        Goblin goblin1 = new Goblin("Trasgo", 25, 200, 0, inventary5);
        Orc orc1 = new Orc("Azog", 40, 200, 0, 2, inventary6);


        dwarf1.AddItems( axe1);
        dwarf1.AddItems( helmet1);
        dwarf1.AddItems( chestplate1);
        dwarf1.AddItems( leggins1);
        dwarf1.AddItems( boots1);

        elf1.hybridInventary.Add( bow1);

        hobbit1.AddItems( sword3);
        }
    }
}
