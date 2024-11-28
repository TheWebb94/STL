using STL___Slower_Than_Light.Spaceships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            //commented out while i work out if im using this
           // int playerHealth = playerShip.TotalHealth;
           // int enemyHealth = enemyShip.TotalHealth;

            DrawStats();

            while (inCombat)
            {
                PlayersTurn();

            }
        }

        private void PlayersTurn()
        {
            MenuOptions.DrawPlayerTurnOptions();
            DrawChanceToHitOnComponents();

            char playerChoice = MenuOptions.PlayerEntry(MenuNames.Scenario, new List<char> { '1', '2', '3', '4' });

            switch (playerChoice)
            {
                case '1':
                   //engines
                    break;
                case '2':
                   //hull
                    break;
                case '3':
                    //wep
                    break;
                case '4':
                    //cock
                    break;
            }
        }

        private void DrawChanceToHitOnComponents()
        {
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 20, 1);
            Console.WriteLine(playerShip.CalculateChanceToHit(enemyShip, TargetComponent.Engines, DistanceToEnemy()) + "%");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 20, 2);
            Console.WriteLine(playerShip.CalculateChanceToHit(enemyShip, TargetComponent.Hull, DistanceToEnemy()) + "%");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 20, 3);
            Console.WriteLine(playerShip.CalculateChanceToHit(enemyShip, TargetComponent.Weapons, DistanceToEnemy()) + "%");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 20, 4);
            Console.WriteLine(playerShip.CalculateChanceToHit(enemyShip, TargetComponent.Cockpit, DistanceToEnemy()) + "%");
        }

        public void DrawDistanceToEnemy()
        {
            double distanceToEnemyXY = DistanceToEnemy();

            // Draw enemy ship type and distance
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, 0);
            Console.WriteLine($"Ship Type: {ShipType.Drone}");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, 1);
            Console.WriteLine($"Distance: {distanceToEnemyXY:0.000}");

        }

        private double DistanceToEnemy()
        {
            int distanceToEnemyX = DistanceToEnemyX();
            int distanceToEnemyY = DistanceToEnemyY();
            double distanceToEnemyXY = Math.Sqrt((distanceToEnemyX * distanceToEnemyX) + (distanceToEnemyY * distanceToEnemyY));
            return distanceToEnemyXY;
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
