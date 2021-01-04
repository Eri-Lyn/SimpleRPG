using System;
using System.Collections.Generic;
using System.Text;

//connects us to Models folder; allows us to look for Player
using Engine.Models;

//The ViewModels Folder connects Models and the MainWindow;

namespace Engine.ViewModels
{
    public class GameSession
    {
        //Using Player allows us to connect to Players in Models folder
        public Player CurrentPlayer { get; set; }

        //Will be creating character instances in other ways in the future, but for notes sake:
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Eri";
            CurrentPlayer.CharacterClass = "UwU";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.ExpPoints = 0;
            CurrentPlayer.Gold = 50;
            CurrentPlayer.Level = 1;

        }
    }
}
