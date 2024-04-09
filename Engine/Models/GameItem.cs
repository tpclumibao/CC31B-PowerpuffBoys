using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }


        public GameItem(int itemTypeID, string name, int price, string imageName)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }


    }

    public class Weapon : GameItem
    {
        public int MinimumDamage {  get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, string imageName, int minDamage, int maxDamage) 
            : base(itemTypeID, name, price, imageName)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, ImageName, MinimumDamage, MaximumDamage);
        }
    }
 
}

