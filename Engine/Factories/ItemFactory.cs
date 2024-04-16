using Engine.Actions;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildWeapon(1001, "Inquisitor Blade", 5, "pack://application:,,,/Engine;component/Images/Items/Inqui.jpg", 1, 3);
            BuildWeapon(1002, "Blade of Rebelion", 100, "pack://application:,,,/Engine;component/Images/Items/Rebel.jpg", 1, 4);
            BuildWeapon(1003, "Franks Hook", 100, "pack://application:,,,/Engine;component/Images/Items/Hook.jpg", 1, 10);

            BuildWeapon(1501, "Rusted Sword", 0, "villainitem", 0, 2);
            BuildWeapon(1502, "Crucifix", 0, "villainitem", 0, 3);
            BuildWeapon(1503, "Thorns", 0, "villainitem", 1, 5);
            BuildWeapon(1504, "Fang", 0, "villainitem", 4, 12);
            BuildWeapon(1505, "Primordial Chaos", 0, "villainitem", 5, 15);

            BuildHealingItem(2001, "Potion of Sacrifice", 25, 25, "pack://application:,,,/Engine;component/Images/Items/Potion.jpg");

            BuildMiscellaneousItem(2501, "Crown of Asea", 100, "collectibleonly");
            BuildMiscellaneousItem(2502, "Echoas of Order", 2, "collectibleonly");
            BuildMiscellaneousItem(2503, "Plague Sack", 1, "collectibleonly");
            BuildMiscellaneousItem(2504, "Grotesque Corpses", 3, "collectibleonly");
            BuildMiscellaneousItem(2505, "Bloody Hearth", 0, "collectibleonly");
            BuildMiscellaneousItem(2506, "Torn Lower Body", 0, "collectibleonly");
            BuildMiscellaneousItem(2506, "Rat Dung", 0, "collectibleonly");
            BuildMiscellaneousItem(2506, "Rotting Root", 0, "collectibleonly");
            BuildMiscellaneousItem(2506, "Dust", 0, "collectibleonly");

            BuildMiscellaneousItem(3001, "Old Jar", 20, "collectibleonly");
            BuildMiscellaneousItem(3002, "Fresh Hearth", 20, "collectibleonly");
            BuildMiscellaneousItem(3003, "Finger", 20, "collectibleonly");

            //s_GameItems.Add(new Weapon(1001, "Stick", 0, "pack://application:,,,/Engine;component/Images/Items/stick.png", 1, 10));
            //s_GameItems.Add(new GameItem(2001, "Imp Essence", 10, "pack://application:,,,/Engine;component/Images/Items/potion.png"));
            //s_GameItems.Add(new GameItem(2002, "Potion", 100, "pack://application:,,,/Engine;component/Images/Items/potion.png"));
            //s_GameItems.Add(new GameItem(9001, "placeholder", 10000, "pack://application:,,,/Engine;component/Images/Items/stick.png"));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price, string imageName)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price, imageName));
        }
        private static void BuildWeapon(int id, string name, int price, string imageName,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, imageName, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal, string imageName)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price, imageName);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }

    }
}