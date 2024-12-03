using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
   

    /// <summary>
    /// Creation of player and enemy ships, giving locations, stats, and draws them
    /// </summary>
    public class Spaceship
    {
        int _positionX;
        int _positionY;
        ShipType _shipType;
        public ShipWeapons Weapon { get; set; }
        public ShipHullLevel Hull { get; set; }
        public ShipEngineLevel Engine { get; set; }
        public int Armour { get; private set; }
        public int DodgeChance { get; private set; }
        public int Damage { get; private set; }
        public int Accuracy { get; private set; }

        public int EngineSize { get; private set; }
        public int EngineHealth { get;  set; }

        public int WeaponSize { get; private set; }
        public int WeaponHealth { get; set; }

        public int HullSize { get; private set; }
        public int HullHealth { get; set; }
        public int CockpitSize { get; private set; }
        public int CockpitHealth { get; set; }

        public int TotalHealth { get;  set; }



        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }

        // constructor that sets default values for ship type, location, and stats
        public Spaceship(ShipType shipType, ShipWeapons weapon = ShipWeapons.none, ShipHullLevel hull = ShipHullLevel.Basic, ShipEngineLevel engine = ShipEngineLevel.Thrusters)
        {
            _shipType = shipType;
            Weapon = weapon;
            Hull = hull;
            Engine = engine;
            SetShipLocation();
            UpdateShipStats();
        }

        /// <summary>
        /// This updates the ships current stats so the stats can reconfigure as the player makes changes in the hangar, and again between turns in combat
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void UpdateShipStats()
        {
            
            CockpitSize = 1;
            CockpitHealth = 20;

            switch (Engine)
            {
                case ShipEngineLevel.Thrusters:
                    DodgeChance = 5;
                    EngineSize = 2;
                    EngineHealth = 20;
                    break;

                case ShipEngineLevel.DoubleBoosters:
                    DodgeChance = 10;
                    EngineSize = 4;
                    EngineHealth = 20;
                    break;

                case ShipEngineLevel.HyperDrive:
                    DodgeChance = 20;
                    EngineSize = 5;
                    EngineHealth = 20;
                    break;

                case ShipEngineLevel.Drone:
                    DodgeChance = 25;
                    EngineSize = 2;
                    EngineHealth = 10;
                    break;

                default:
                    throw new NotImplementedException();
            }

            switch (Weapon)
            {
                case ShipWeapons.Laser:
                    Accuracy = 90;
                    Damage = 40;
                    WeaponSize = 2;
                    WeaponHealth = 20;
                    break;
                case ShipWeapons.Missile:
                    Accuracy = 70;
                    Damage = 60;
                    WeaponSize = 4;
                    WeaponHealth = 20;
                    break;
                case ShipWeapons.Beam:
                    Accuracy = 95;
                    Damage = 35;
                    WeaponSize = 4;
                    WeaponHealth = 20;
                    break;
                default : 
                    throw new NotImplementedException();
            }

            switch (Hull)
            {
                case ShipHullLevel.Basic:
                    Armour = 0;
                    HullSize = 4;
                    HullHealth = 50;
                    break;
                case ShipHullLevel.Reinforced:
                    Armour = 10;
                    HullSize = 5;
                    HullHealth = 100;
                    break;
                case ShipHullLevel.HeavilyArmoured:
                    Armour = 20;
                    HullSize = 6;
                    HullHealth = 150;
                    break;
                case ShipHullLevel.Drone:
                    Armour = 10;    
                    HullSize = 8;
                    HullHealth = 50;
                    break;
                default:
                    throw new NotImplementedException();
            }

            TotalHealth = CockpitHealth + EngineHealth + WeaponHealth + HullHealth; 
        }

        /// <summary>
        /// This draws the stats for the chosen ship, used in the hangar and for each player+enemy ship while in combat
        /// </summary>
        /// <param name="offsetY"></param>
        /// <param name="displayShipType"></param>
        public void DisplayShipStats(int offsetY = 0, bool displayShipType = true)
        {
            if (displayShipType)
            {
                MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY);
                Console.WriteLine($"Ship Type:   {_shipType}");
                offsetY++;
            }
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 1);
            Console.WriteLine($"Health:      {TotalHealth} ");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 2);
            Console.WriteLine($"Armour:      {Armour}");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 3);
            Console.WriteLine($"Damage:      {Damage}");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 4);
            Console.WriteLine($"Accuracy:    {Accuracy}");
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 5);
            Console.WriteLine($"Dodge%:      {DodgeChance}");
        }

        /// <summary>
        /// Method to draw the player or enemy ship
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void DrawShip()
        {
            switch (_shipType)
            {
                case ShipType.Player:
                    DrawPlayerShip();

                    break;
               
                case ShipType.Drone:
                    DrawDroneShip();
                    break;

                default:
                    throw new NotImplementedException("ShipType not registered");
            }
        }

        /// <summary>
        /// Method to give initial location for the spawned ship. player is fixed, enemy should be random within a given range
        /// </summary>
        public void SetShipLocation()
        {
            switch(_shipType)
            {
                case ShipType.Player:
                    SetLocation(5, 8);
                    break;
                case ShipType.Drone:
                    var (x, y) = GetRandomCoordinates();
                    SetLocation(x, y);  

                    break;
            }
        }

        /// <summary>
        /// Gets the random x and y spawn location for enemyship
        /// </summary>
        /// <returns></returns>
        private (int, int) GetRandomCoordinates()
        {
            Random random = new Random();
            var x = random.Next(30, 84);   
            var y = random.Next(1, 15);
            return (x, y);
        }

        private void SetLocation(int x, int y)
        {
            _positionX = x;
            _positionY = y;
        }

        /// <summary>
        /// Draws the player ship
        /// </summary>
        private void DrawPlayerShip()
        {
            Console.SetCursorPosition(_positionX, _positionY);
            Console.Write(SpaceshipComponentDrawer.EngineBuilder(Engine.ToString()));
            Console.SetCursorPosition(_positionX, _positionY + 1);
            Console.Write(SpaceshipComponentDrawer.WeaponBuilder(Weapon.ToString()));
            Console.SetCursorPosition(_positionX, _positionY + 2);
            Console.Write(SpaceshipComponentDrawer.HullBuilder(Hull.ToString()));
            Console.SetCursorPosition(_positionX, _positionY + 3);
            Console.Write(SpaceshipComponentDrawer.WeaponBuilder(Weapon.ToString()));
            Console.SetCursorPosition(_positionX, _positionY + 4);
            Console.Write(SpaceshipComponentDrawer.EngineBuilder(Engine.ToString()));

        }
        
        /// <summary>
        /// Draws the drone
        /// </summary>
        private void DrawDroneShip()
        {
            Console.SetCursorPosition(_positionX, _positionY);
            Console.Write("--==--");
            Console.SetCursorPosition(_positionX, _positionY + 1);
            Console.Write("[|||]");
            Console.SetCursorPosition(_positionX, _positionY + 2);
            Console.Write(" {00}");
            Console.SetCursorPosition(_positionX, _positionY + 3);
            Console.Write("[|||]");
            Console.SetCursorPosition(_positionX, _positionY + 4);
            Console.Write("--==--");
        }

        //Chance to hit was calculated with an equation i modeled (in the excel sheet "Attack balancing sheet")
        public double CalculateChanceToHit(Spaceship target, TargetComponent targetComponent, double distance)
        {
            double distanceDifficultyModifier = 1 / (Math.Sqrt(distance) * 5); // accuracy with only distance factored
           
            double chanceToHit = 100*(1 - Math.Pow(distanceDifficultyModifier, 0.4 * GetComponentSize(target,targetComponent))); // accuracy before factoring in weapon accuracy chance to hit - normalised to 1-100 value

            chanceToHit = (chanceToHit * Accuracy)/100;  //accuracy once weapon accuracy added

            chanceToHit -= target.DodgeChance; //after factoring enemy dodgeechance

            double result = Math.Round(chanceToHit,0); 

            return result;
        }

        /// <summary>
        /// performs the attack on the targeted spaceship
        /// </summary>
        /// <param name="target">give the player or enemy ship (shiptype)</param>
        /// <param name="targetComponent">give the component the player wants to target</param>
        /// <param name="distance">how far away the target and ship firing are</param>
        /// <param name="hitChance">the number to beat when rolling to hit the target</param>
        /// <param name="isPlayerAttacking">changes the messaging when logging the result of the attack so that is unique for the player and enemy attack turns</param>
        /// <returns></returns>
        public string Attack(Spaceship target, TargetComponent targetComponent, double distance, double hitChance, bool isPlayerAttacking)
        {
            bool isHit = RollToHit(hitChance);

            if (isHit)
            {
                int baseDamage = Damage;
                int adjustedDamage = Math.Max(baseDamage - target.Armour, 0);

                if (targetComponent == TargetComponent.Cockpit)
                {
                    int bonusDamage = 20;
                    adjustedDamage = bonusDamage + adjustedDamage;

                    target.TotalHealth -= adjustedDamage;

                    if (isPlayerAttacking)
                    {
                        return $"Hit the cockpit dealing {bonusDamage} bonus damage, for {adjustedDamage} total!";
                    }
                    else
                    {
                        return $"Your cockpit was hit for {bonusDamage} bonus damage, for {adjustedDamage} total!";
                    }
                }

                target.TotalHealth -= adjustedDamage;

                if (isPlayerAttacking)
                {
                    return $"Hit the {targetComponent} of the enemy's ship dealing {adjustedDamage} damage!";
                }
                else
                {
                    return $"Your {targetComponent} was hit by the enemy for {adjustedDamage} damage!       ";
                }
            }
            else
            {
                if (isPlayerAttacking)
                {
                    return $"Your attack on the enemy {targetComponent} missed!";
                }
                else
                {
                    return $"Enemy attack on your {targetComponent} missed!";
                }
            }
        }

        /// <summary>
        /// performs the roll to hit
        /// </summary>
        /// <param name="hitChance">the target to beat, give maximum for 1%, 0 for guaranteed hit</param>
        /// <returns></returns>
        private static bool RollToHit(double hitChance)
        {
            Random random = new Random();

            bool isHit = random.Next(100) <= hitChance;

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 6);
            return isHit;
        }

        /// <summary>
        /// Checks the target components size so accuracy calculation can be made
        /// </summary>
        /// <param name="target"></param>
        /// <param name="targetComponent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int GetComponentSize(Spaceship target,TargetComponent targetComponent)
          {
                switch (targetComponent)
                 {
                    case TargetComponent.Engines:
                        return target.EngineSize;

                     case TargetComponent.Weapons:
                        return target.WeaponSize;

                     case TargetComponent.Hull:
                        return target.HullSize;

                     case TargetComponent.Cockpit:
                        return target.CockpitSize;

                     default: throw new Exception();
                }
          }
    }

    public enum ShipType
    {
        Player,
        Drone,
        Enemy
        
    }

    public enum ShipWeapons
    {
        none,
        Laser,
        Missile,
        Beam
    }

    public enum ShipHullLevel
    {
        Basic,
        Reinforced,
        HeavilyArmoured,
        Drone
    }

    public enum ShipEngineLevel
    {
        Thrusters,
        DoubleBoosters,
        HyperDrive,
        Drone
    }

    public enum TargetComponent
    {
        Engines,
        Hull,
        Weapons,
        Cockpit
    }

}
