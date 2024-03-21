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
        public int ItemTypeID;
        public string Name;
        public int Price;
        public string ImageName;
        public int MinimumDamage;
        public int MaximumDamage;


        public GameItem(int ItemTypeID, string Name, int Price, string ImageName, int MinimumDamage, int MaximumDamage)
        {
            this.ItemTypeID = ItemTypeID;
            this.Name = Name;
            this.Price = Price;
            this.ImageName = ImageName;
            this.MinimumDamage = MinimumDamage;
            this.MaximumDamage = MaximumDamage;
        }

        public GameItem Clone()
        {
            return new GameItem(this.ItemTypeID, this.Name, this.Price, this.ImageName, this.MinimumDamage, this.MaximumDamage);
        }


    }

    public class Weapon : GameItem
    {

        public Weapon(int ItemTypeID, string Name, int Price, string ImageName, int MinimumDamage, int MaximumDamage) 
            : base(ItemTypeID, Name, Price, ImageName, MinimumDamage, MaximumDamage)
        {
            
        }

        public new Weapon Clone()
        { 
            GameItem clonedItem = (GameItem)base.Clone();
            return (Weapon)clonedItem;
        }
    }
 
}

