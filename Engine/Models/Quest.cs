using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    internal class Quest
    {
        public int ID { get; set; }
        public Quest(int ID, string Name, string Description, List<ItemQuantity> ItemsToComplete, int RewardExpPoints, int RewardGold, List<ItemQuantity> RewardItems) 
        {
            this.ID = ID;
        }  
    }
}
