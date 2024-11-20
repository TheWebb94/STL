using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Scenario
    {
        Spaceship playerShip;
        Spaceship enemyShip;

        public Spaceship PlayerShip { get => playerShip; set => playerShip = value; }
        public Spaceship EnemyShip { get => enemyShip; set => enemyShip = value; }

        public void LaunchScenario() 
        {
            Console.Clear();
            DrawUI.Scenario();

            var newShip = new SpaceShipFactory();

            playerShip = newShip.SpawnSpaceShip(ShipType.Player);
            playerShip.DrawShip();

            enemyShip = newShip.SpawnSpaceShip(ShipType.Drone);
            enemyShip.DrawShip();

            MenuOptions.SetCursorLocationTitleMenu();
        }
    }
}
