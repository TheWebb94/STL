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

            while (inCombat)
            {
                DrawStats();

                PlayersTurn();

                DrawStats();

                Console.ReadKey();

                if (!IsSpaceshipAlive(enemyShip))
                {
                    MenuOptions.ClearMenuPanel();
                    MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 0);
                    Console.WriteLine("Enemy spaceship has been destroyed                                               ");
                    MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 1);
                    MenuOptions.PressToContinue();
                    DrawUI.GameVictory();
                    inCombat = false;
                    break;
                }

                EnemysTurn();

                DrawStats();
                
                Console.ReadKey();

                if (!IsSpaceshipAlive(playerShip))
                {
                    MenuOptions.ClearMenuPanel();
                    MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 0);
                    Console.WriteLine("Your spaceship has been destroyed                                              ");
                    MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 1);
                    MenuOptions.PressToContinue();
                    DrawUI.GameOver();
                    inCombat = false;
                    break;
                }
               
            }
        }

        private void EnemysTurn()
        {

            MenuOptions.ClearMenuPanel();

            TargetComponent targetComponent = SelectRandomTarget();

            double distance = DistanceToEnemy();
            double chanceToHit = enemyShip.CalculateChanceToHit(playerShip, targetComponent, distance);

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 0);
            Console.WriteLine($"Enemy attacking your {targetComponent} with {chanceToHit}% chance to hit!       ");

            // Perform the attack and capture the result
            string attackResult = enemyShip.Attack(playerShip, targetComponent, distance, chanceToHit, false);

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 5);
            MenuOptions.PressToContinue();

            // Display the result of the attack
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 1);
            Console.WriteLine(attackResult);
        }

        private TargetComponent SelectRandomTarget()
        {
            Array components = Enum.GetValues(typeof(TargetComponent));
            Random random = new Random();
            return (TargetComponent)components.GetValue(random.Next(components.Length));
        }

        private bool IsSpaceshipAlive(Spaceship targetSpaceship)
        {
            if (targetSpaceship.TotalHealth <= 0)
            {
                return false;
            }
           else 
                return true;
        }

        private void PlayersTurn()
        {
            MenuOptions.ClearMenuPanel();
            
            MenuOptions.DrawPlayerTurnOptions();
            DrawChanceToHitOnComponents();

            char playerChoice = MenuOptions.PlayerEntry(MenuNames.Scenario, new List<char> { '1', '2', '3', '4' });

            TargetComponent targetComponent = SetAttackTarget(playerChoice);

            double distance = DistanceToEnemy();

            double chanceToHit = playerShip.CalculateChanceToHit(enemyShip, targetComponent, distance);

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 5);

            Console.WriteLine($"Attacking {targetComponent} with {chanceToHit}% chance to hit!            ");

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 6);
            MenuOptions.PressToContinue();

            string attackResult = playerShip.Attack(enemyShip, targetComponent, distance, chanceToHit, true);


            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 6);

            Console.WriteLine(attackResult);

        }

        private static TargetComponent SetAttackTarget(char playerChoice)
        {
            TargetComponent targetComponent;
            switch (playerChoice)
            {
                case '1':
                    targetComponent = TargetComponent.Engines;
                    break;
                case '2':
                    targetComponent = TargetComponent.Hull;
                    break;
                case '3':
                    targetComponent = TargetComponent.Weapons;
                    break;
                case '4':
                    targetComponent = TargetComponent.Cockpit;
                    break;
                default:
                    targetComponent = TargetComponent.Hull;
                    break;
            }

            return targetComponent;
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
