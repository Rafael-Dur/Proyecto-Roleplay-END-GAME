using System;
using System.Collections.Generic;
using RolePlayEndGame;

using NUnit.Framework;


namespace RolePlayEndGame
{
    public class CharacterTest
    {
        private Dwarf character1;
        private Hobbit character2;
        private Wizard character3;
        private Demon character4;
        private Dragon character5;
        private Goblin character6;
        private Orc character7;

        private Bow bow;

        [SetUp]
        public void SetUp()
        {
            List<Item> inventary1 = new List<Item>();
            List<Item> inventary2 = new List<Item>();
            List<Item> inventary3 = new List<Item>();
            List<Item> inventary4 = new List<Item>();

            List<MagicItem> magicInventary1 = new List<MagicItem>();
            List<MagicItem> magicInventary2 = new List<MagicItem>();

            List<Item> hybridInventary = new List<Item>();


            bow = new Bow("Long Bow", 15, 0, "Ataque de largo alcance", true);

            character1 = new Dwarf("Thorin", 40, 250, 0, inventary1, 20);
            character2 = new Hobbit("Bilbo", 20, 200, 0, inventary2, 5);
            character3 = new Wizard("Gandalf", 25, 280, 30, 30, magicInventary1);
            character4 = new Demon("Asmoudeus", 30, 280, 20, 30, magicInventary2);
            character5 = new Dragon("Smaug", 100, 500, 0, 5, hybridInventary);
            character6 = new Goblin("Trasgo", 25, 200, 0, inventary3);
            character7 = new Orc("Azog", 40, 200, 0, 2, inventary4);
        }

        [Test]
        public void AttackTest1()
        {
            character7.Attack(character1);
            /*Daño del orco: 80
              Defensa del enano: 270*/
            Assert.AreEqual(190, character1.health);

        }
        
        [Test]
        public void AttackTest2()
        {
            character3.Attack(character4);
            /*Daño del mago total: 55
              Defensa del demonio: 280*/
            Assert.AreEqual(225, character4.health);

        }

        [Test]
        public void AttackTest3()
        {
            character4.Attack(character2);
            /*Daño del demonio total: 60
              Defensa del hobbit: 200*/
            Assert.AreEqual(145, character4.health);
        }

        [Test]
        public void AttackTest4()
        {
            character1.AddItems(bow);
            character1.Attack(character5);
            /*Daño del enano: 55 (su daño más el del arco)
              Defensa del dragón: 445*/
              Assert.AreEqual(445, character5.health);
        }
    }
}