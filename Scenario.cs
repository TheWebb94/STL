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

            DrawStats();

            FightStats stats = new FightStats(this);
            stats.DrawCombatInfo();

            StartCombat(stats);
        }

        private void DrawStats()
        {
            playerShip.DisplayShipStats(10);
            enemyShip.DisplayShipStats(2, false);
        }

        private void StartCombat(FightStats stats)
        {
            bool inCombat = true;

            while (inCombat)
            {

            }
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
