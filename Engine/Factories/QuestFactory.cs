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
        static QuestFactory()
        {
            _quests = new List<Quest>();
            _quests.Add(new Quest(10, "Spilling Waste", "The Drunk Barkeep sees the golden days of Asea, He wants you to bring him 5 Plague Sacks so he can improve his brew.", 5, 10, 10, 106));
        }
    }
}
