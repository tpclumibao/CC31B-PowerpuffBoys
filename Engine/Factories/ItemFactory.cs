using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            _standardGameItems.Add(new Weapon(101, "Inquisitor Blade", 5, "", 0, 10));
            _standardGameItems.Add(new Weapon(102, "Blade of Rebelion", 20, "", 5, 10));
            _standardGameItems.Add(new Weapon(103, "Franks Hook", 20, "", 6, 6));
            _standardGameItems.Add(new GameItem(500, "Crown of Asea", 100, ""));
            _standardGameItems.Add(new GameItem(501, "Echoas of Order", 2, ""));
            _standardGameItems.Add(new GameItem(502, "Plague Sack", 1, ""));
            _standardGameItems.Add(new GameItem(503, "Eroded Corps", 0, ""));
            _standardGameItems.Add(new GameItem(504, "Bloody Hearth", 0, ""));
            _standardGameItems.Add(new GameItem(505, "Torn Lower Body", 0, ""));
            _standardGameItems.Add(new GameItem(506, "Rat Dung", 0, ""));
            _standardGameItems.Add(new GameItem(507, "Rotting Root", 0, ""));
            _standardGameItems.Add(new GameItem(508, "Dust", 0, ""));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}