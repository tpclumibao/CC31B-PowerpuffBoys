using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader shady = new Trader("Shady Man");

            for (int x = 0; x < 50; x++)
            {
                shady.AddItemToInventory(ItemFactory.CreateGameItem(1002));
                shady.AddItemToInventory(ItemFactory.CreateGameItem(1003));
            }
            Trader calli = new Trader("Calli");
            calli.AddItemToInventory(ItemFactory.CreateGameItem(3001));
            calli.AddItemToInventory(ItemFactory.CreateGameItem(3002));
            calli.AddItemToInventory(ItemFactory.CreateGameItem(3003));
            AddTraderToList(shady);
            AddTraderToList(calli);

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