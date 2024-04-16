using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0,
                "Gates of Asea",
                "The stained Grand Gates of Asea Greets you",
                "Gate.png","Gate.png");
                newWorld.LocationAt(0, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(1, 0,
                "Lower Hellion Plaza",
                "The once bustling plaza of Asea, now as empty as a wasteland",
                "Lower.png", "Lower.png");
                newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            newWorld.AddLocation(1, 1,
                "Tearfull Tavern",
                "As you Enter an old rundown tavern. it stil stinks of bear",
                "Tavern.png", "Tavern.png");
                newWorld.LocationAt(1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(1, -1,
                "SpillWay Inn",
                "You enter an inn you supposed. it looks more like a honted house",
                "Inn.png", "Inn.png");
                newWorld.LocationAt(1, -1).TraderHere = TraderFactory.GetTraderByName("Calli");

            newWorld.AddLocation(2, 0,
               "Upper HellionPlaza",
               "You stand in front of the Grand castle of asea",
               "Upper.png", "Upper.png");
                newWorld.LocationAt(2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));
                newWorld.LocationAt(2, 0).TraderHere = TraderFactory.GetTraderByName("Calli");

            newWorld.AddLocation(2, 1,
                "Church of Erebus",
                "A once Church to gods of good now flooded with cultist.",
                "Church.png", "Church.png");
                newWorld.LocationAt(2, 1).AddMonster(2, 100);

            newWorld.AddLocation(2, -1,
                "Withering Garden",
                "A once grand garden, now withered. but one house tall flower stands.",
                "Garden.png", "Garden.png");
                newWorld.LocationAt(2, -1).AddMonster(3, 100);

            newWorld.AddLocation(3, 0,
                "Castle of Blight",
                "You have entered the halls of the castle. it is still magnificent even with the chaos",
                "Castle.png", "Castle.png");
                newWorld.LocationAt(3, 0).AddMonster(4, 100);

            newWorld.AddLocation(1, 2,
                "Sewers",
                "It stinks... stool and Rats litter the place",
                "Sewer.png", "Sewer.png");
                newWorld.LocationAt(1, 2).AddMonster(1, 100);

            newWorld.AddLocation(4, 0,
                "Cliff View",
                "A High cliff behind the castle. facing the Dark oceans of asea",
                "Cliff.png", "Cliff.png");






            return newWorld;
        }
    }
}
