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
        private static List<Quest> _quests;
        private static List<ItemQuantity> _items;
        static QuestFactory()
        {
            _items = new List<ItemQuantity>();
            _items.Add(new ItemQuantity(1001, 5));
            _items.Add(new ItemQuantity(1002, 5));
            _items.Add(new ItemQuantity(1003, 3));
            _items.Add(new ItemQuantity(1004, 1));

            _quests = new List<Quest>();
            _quests.Add(new Quest(10, "Spilling Waste", "The Drunk Barkeep sees the golden days of Asea, He wants you to bring him 5 Plague Sacks form the sewers so he can improve his brew.",_items, 10, 10, _items));
            _quests.Add(new Quest(11, "Fallen Valor", "The once renowned hero of Asea has fallen to be the likes of a simple gate keep. He wants you to Eliminate those cultist scum who worship that sorry excuse of a God", _items, 10, 10, _items));
            _quests.Add(new Quest(12, "Shatered Mind", "A mother has lost her children, she wants you to find Fred, Jancer, and John for it's time for supper. They should be playing in the Gardens", _items, 10, 10, _items));
            _quests.Add(new Quest(11, "Royal Decree", "The king of Asea once Hailed to be the strongest knight is now bound to the deceased body of his pregnant wife. He want's you to kill Erebus and all related to him for his revenge", _items, 10, 10, _items));
        }

        public static Quest GetQuestByID(int questID)
        {
            return _quests.FirstOrDefault(quest => quest.ID == questID);
        }

    }
}
