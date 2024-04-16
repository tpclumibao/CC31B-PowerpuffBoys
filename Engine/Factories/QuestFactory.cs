using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static List<Quest> s_Quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(2502, 5));
            rewardItems.Add(new ItemQuantity(3003, 3));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();
            itemsToComplete2.Add(new ItemQuantity(2503, 5));
            rewardItems2.Add(new ItemQuantity(3001, 3));

            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();
            itemsToComplete3.Add(new ItemQuantity(2504, 3));
            rewardItems3.Add(new ItemQuantity(3002, 3));

            List<ItemQuantity> itemsToComplete4 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems4 = new List<ItemQuantity>();
            itemsToComplete4.Add(new ItemQuantity(2501, 1));
            rewardItems4.Add(new ItemQuantity(1003, 1));


            s_Quests.Add(new Quest(1,
                                  "Slay the Heretics",
                                  "Kill the priests ang get 5 Echoes of Order",
                                  itemsToComplete,
                                  20, 25,
                                  rewardItems));

            s_Quests.Add(new Quest(2,
                                  "THE RATSS!!!",
                                  "Kill the rats in the sewers and get 5 Plague Sacks",
                                  itemsToComplete2,
                                  20, 25,
                                  rewardItems2));

            s_Quests.Add(new Quest(3,
                                  "NOOOO!!!!",
                                  "Helf the mother finder her 3 son's ",
                                  itemsToComplete3,
                                  50, 50,
                                  rewardItems3));

            s_Quests.Add(new Quest(4,
                                  "Disgrace...",
                                  "The king wants you to kill that lunatic of a god and bring back the treasure of Asea",
                                  itemsToComplete4,
                                  100, 200,
                                  rewardItems4));

        }
        internal static Quest GetQuestByID(int id)
        {
            return s_Quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}

