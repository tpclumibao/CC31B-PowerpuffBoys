using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;


namespace Engine.Factories
{
    internal class QuestFactory
    {
        private static List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            //Declare the items needed to complete the quest and the reward items
           List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
           List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(501, 5));
            rewardItems.Add(new ItemQuantity(101,1));
            
            //Create Quest
            _quests.Add(new Quest(1,
                "Slay the Heretics",
                "Kill the priest of Erebus in the Church",
                itemsToComplete,
                25, 10,
                rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }

    }
}
