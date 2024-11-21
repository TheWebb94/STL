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

        public void LaunchScenario() 
        {
            Console.Clear();
            DrawUI.Scenario();

            var newShip = new SpaceshipFactory();

            playerShip.DrawShip();

            enemyShip = newShip.SpawnSpaceShip(ShipType.Drone);
            enemyShip.DrawShip();

            MenuOptions.ResetCursorPosition(MenuNames.Title);
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
