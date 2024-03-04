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
        public GameSession() 
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Themis";
            CurrentPlayer.CharacterClass = "Inquisitor";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
