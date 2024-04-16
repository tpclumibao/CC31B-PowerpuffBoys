using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster rat =
                        new Monster("PlagueRat", "Rat.png", 4, 4, 5, 5);
                    AddLootItem(rat, 502, 25);
                    AddLootItem(rat, 506, 75);
                    return rat;
                case 2:
                    Monster priest =
                        new Monster("PriestOfErebus", "Priest.png", 5, 5, 5, 5);
                    AddLootItem(priest, 501, 25);
                    AddLootItem(priest, 505, 75);
                    return priest;
                case 3:
                    Monster flower =
                        new Monster("DeathBloom", "Flower.png", 10, 10, 5, 5);
                    AddLootItem(flower, 503, 25);
                    AddLootItem(flower, 507, 75);
                    return flower;
                case 4:
                    Monster Corps =
                        new Monster("BlightedKnights", "Knights.png", 10, 10, 5, 5);
                    AddLootItem(Corps, 508, 100);
                    return Corps;
                case 5:
                    Monster Erebus =
                        new Monster("Primordial God Erebus", "Erebus.png", 10, 10, 5, 5);
                    AddLootItem(Erebus, 500, 100);
                    return Erebus;


                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}