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
                "Entrance to Asea", 
                "You arive at your destination it seems. As you look in fron of you, the once magestic gates of asea stand before you, crumbling and painted in red", 
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");

            newWorld.LocationAt(0,0).QuestAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(1, 0,
                "LowerHellion Plaza",
                "The once bustling plaza of Asea, now littered with corpses of both the young and old",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");

            newWorld.AddLocation(1, 1,
                "Tearfull Tavern",
                "As you Enter the rundown taver, you notice that its still being kept relatively clean. a stark contrast to whats outside",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");

            

            newWorld.AddLocation(1, -1,
                "SpillWay Inn",
                "You arive at your destination it seems. As you look in fron of you, the once magestic gates of asea stand before you, crumbling and painted in red",
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");

            newWorld.AddLocation(2, 0,
               "Upper HellionPlaza",
               "As you Enter the rundown taver, you notice that its still being kept relatively clean. a stark contrast to whats outside",
               "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");

            newWorld.AddLocation(2, 1,
                "Church of Erebus",
                "The once bustling plaza of Asea, now littered with corpses of both the young and old",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");

            newWorld.AddLocation(2, -1,
                "Withering Garden",
                "As you Enter the rundown taver, you notice that its still being kept relatively clean. a stark contrast to whats outside",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");

            newWorld.AddLocation(3, 0,
                "Castle of Blight",
                "You arive at your destination it seems. As you look in fron of you, the once magestic gates of asea stand before you, crumbling and painted in red",
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");

            newWorld.AddLocation(1, 2,
                "Sewers",
                "The once bustling plaza of Asea, now littered with corpses of both the young and old",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");

            newWorld.AddLocation(4, 0,
                "Cliff View",
                "As you Enter the rundown taver, you notice that its still being kept relatively clean. a stark contrast to whats outside",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");



            return newWorld;
        }
    }
}
