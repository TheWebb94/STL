using System;
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

        public void Draw()
        {
           int distanceToEnemyX = battleScene.EnemyShip.PositionX - battleScene.PlayerShip.PositionX;
           int distanceToEnemyY = battleScene.EnemyShip.PositionY - battleScene.PlayerShip.PositionY;
           double distanceToEnemyXY = Math.Sqrt((distanceToEnemyX*distanceToEnemyX) + (distanceToEnemyY*distanceToEnemyY));

           MenuOptions.SetCursorLocationStatsMenu(1);
           Console.WriteLine("Ship Type: " + ShipType.Drone);

           MenuOptions.SetCursorLocationStatsMenu(2);
           Console.WriteLine("Distance: " + distanceToEnemyXY.ToString("0.000"));

        }
    }
}
