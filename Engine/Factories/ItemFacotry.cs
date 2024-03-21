using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class ItemFacotry
    {
        private static List<GameItem> _standardGameItems;
        static ItemFacotry()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(101, "Inquisitor Blade", 5, "", 0, 10));
            _standardGameItems.Add(new Weapon(102, "Blade of Rebelion", 20, "", 5, 10));
            _standardGameItems.Add(new Weapon(103, "Franks Hook", 20, "", 6, 6));
            _standardGameItems.Add(new Weapon(104, "Crown of Asea", 100, "", 10, 20));
            _standardGameItems.Add(new Weapon(105, "Echoas of Order", 2, "", 2, 3));
            _standardGameItems.Add(new Weapon(106, "Plague Sack", 1, "", 0, 1));
            _standardGameItems.Add(new Weapon(107, "Eroded Corps", 0, "", 1, 3));
            _standardGameItems.Add(new Weapon(108, "Bloody Hearth", 0, "", 0, 0));

        }

        public static GameItem CreateGameItem()
        {
            if (_standardGameItems.Count > 0)
            {
                return _standardGameItems[0].Clone();

            }
            else
                return null;
        }
    }
}
