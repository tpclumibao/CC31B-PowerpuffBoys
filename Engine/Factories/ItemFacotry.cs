using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFacotry
    {
        private static List<GameItem> _standardGameItems;
        static ItemFacotry()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(101, "Inquisitor Blade", 5, "", 0, 10));
            _standardGameItems.Add(new Weapon(102, "Blade of Rebelion", 20, "", 5, 10));
            _standardGameItems.Add(new Weapon(103, "Franks Hook", 20, "", 6, 6));
            _standardGameItems.Add(new Weapon(104, "Crown of Asea", 100, "", 10, 20));
            _standardGameItems.Add(new GameItem(501, "Echoas of Order", 2, ""));
            _standardGameItems.Add(new GameItem(502, "Plague Sack", 1, ""));
            _standardGameItems.Add(new GameItem(503, "Eroded Corps", 0, ""));
            _standardGameItems.Add(new GameItem(504, "Bloody Hearth", 0, ""));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
