using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader calli = new Trader("Calli");
            calli.AddItemToInventory(ItemFactory.CreateGameItem(101));
            Trader farmerTed = new Trader("Farmer Ted");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            Trader peteTheHerbalist = new Trader("Pete the Herbalist");
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            AddTraderToList(calli);
            AddTraderToList(farmerTed);
            AddTraderToList(peteTheHerbalist);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
