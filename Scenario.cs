using STL___Slower_Than_Light.Spaceships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Scenario
    {

        private Spaceship playerShip = PlayerShipManager.playerSpaceship;
        private Spaceship enemyShip;
        /// <summary>
        /// This draws the combat scenario between player and the enemy
        /// </summary>
        public void LaunchScenario()
        {
            Console.Clear();
            DrawUI.Scenario();

            playerShip.DrawShip();

            var newShip = new SpaceshipFactory();
            enemyShip = newShip.SpawnSpaceShip(ShipType.Drone);
            enemyShip.DrawShip();



            StartCombat();
        }

        private void DrawStats()
        {
            playerShip.DisplayShipStats(10);
            enemyShip.DisplayShipStats(2, false);
            DrawDistanceToEnemy();        
        }

        private void StartCombat()
        {
            bool inCombat = true;

            while (inCombat)
            {
                DrawStats();
            }
        }


        public void DrawDistanceToEnemy()
        {
            int distanceToEnemyX = DistanceToEnemyX();
            int distanceToEnemyY = DistanceToEnemyY();
            double distanceToEnemyXY = Math.Sqrt((distanceToEnemyX * distanceToEnemyX) + (distanceToEnemyY * distanceToEnemyY));

            // Draw enemy ship type and distance
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, 0);
            Console.WriteLine($"Ship Type: {ShipType.Drone}");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, 1);
            Console.WriteLine($"Distance: {distanceToEnemyXY:0.000}");

        }

        internal int DistanceToEnemyX()
        {
            return enemyShip.PositionX - playerShip.PositionX;
        }

        internal int DistanceToEnemyY()
        {
            return enemyShip.PositionY - playerShip.PositionY;
        }

         
    }
}
