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
            playerShip.DisplayShipStats(10);

            var newShip = new SpaceshipFactory();
            enemyShip = newShip.SpawnSpaceShip(ShipType.Drone);
            enemyShip.DrawShip();
            enemyShip.DisplayShipStats(2, false);

            FightStats stats = new FightStats(this);
            stats.DrawCombatInfo();

            bool inCombat = true;
            while (inCombat)
            {
                StartCombat(stats);
            }
        }

        private void StartCombat(FightStats stats)
        {
           // throw new NotImplementedException();
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
