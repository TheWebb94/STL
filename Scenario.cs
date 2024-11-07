﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Scenario
    {
        public static void LaunchScenario() 
        {
            Console.Clear();
            DrawUI.Scenario();
            DrawUI.Starfield();
            DrawSpaceships.PlayerShip();
            DrawUI.Drone();
            MenuOptions.SetCursorLocationTitleMenu();

        }
    }
}