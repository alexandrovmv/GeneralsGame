﻿using GeneralClasses;
using GeneralsClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsClient.ViewModel
{
    public class Engine
    {
        Player P { get; set; }
        Login LoginWindow { get; set;}
        StartGame StartGameWindow { get; set; }
        public Engine()
        {
            LoginWindow = new Login();
            //do
            //{
            LoginWindow.ShowDialog();
            //} while (LoginWindow.DialogResult != true);

            //P = new Player("Vasia");
            //StartGameWindow = new StartGame();
            //StartGameWindow.ShowDialog();

        }
    }
}