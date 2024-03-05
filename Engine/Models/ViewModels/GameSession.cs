using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine.Models.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession() 
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Themis";
            CurrentPlayer.CharacterClass = "Inquisitor";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;


            CurrentLocation = new Location();
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Name = "Grand Gates of Asea";
            CurrentLocation.Description = "The once grand gates of Asea now withered and stained by blood";
            CurrentLocation.ImageName = "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg";
            //CurrentLocation.ImageName = "../Engine:component/Images/Locations/GatesOfAsea.jpg";
        }
    }
}
