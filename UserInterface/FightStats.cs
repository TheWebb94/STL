﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class FightStats
    {
        private Scenario battleScene;

        public FightStats(Scenario battleScene)
        {
            this.battleScene = battleScene;
        }

        public void DrawCombatInfo()
        {
            int distanceToEnemyX = battleScene.DistanceToEnemyX();
            int distanceToEnemyY = battleScene.DistanceToEnemyY();
           double distanceToEnemyXY = Math.Sqrt((distanceToEnemyX*distanceToEnemyX) + (distanceToEnemyY*distanceToEnemyY));

           MenuOptions.ResetCursorPosition(MenuNames.Stats);
           Console.WriteLine("Ship Type: " + ShipType.Drone);

           MenuOptions.ResetCursorPosition(MenuNames.Stats,0,1);
           Console.WriteLine("Distance: " + distanceToEnemyXY.ToString("0.000"));

        }
    }
}