using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
   

    /// <summary>
    /// Creation of player and enemy ships, giving locations, and draws them
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
        /// 
        /// </summary>
        /// <param name="offsetY">how much to offset Y position in menu by</param>
        /// <param name="displayShipType">bool on whether to display the ship type or not</param>
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

        public void UpdateShipComponenetMessage()
        {
            MenuOptions.ResetCursorPosition(MenuNames.Title);
            Console.WriteLine($"Updated {this._shipType} Ship Stats:");
            Console.WriteLine($"Weapon: {Weapon}, Hull: {Hull}, Engine: {Engine}");
        }
        //Chance to hit was calculated with an equation i modeled (in the excel sheet)
        public double CalculateChanceToHit(Spaceship target, TargetComponent targetComponent, double distance)
        {
            double distanceDifficultyModifier = 1 / (Math.Sqrt(distance) * 5); // accuracy with only distance factored
            double chanceToHit = 100*(1 - Math.Pow(distanceDifficultyModifier, 0.4 * GetComponentSize(target,targetComponent))); // accuracy before factoring in weapon accuracy chance to hit - normalised to 1-100 value

            chanceToHit = (chanceToHit * Accuracy)/100;  //accuracy once weapon accuracy added

            chanceToHit -= target.DodgeChance; //after factoring enemy dodgeechance

            double result = Math.Round(chanceToHit,0); 
            return result;
        }

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

        private static bool RollToHit(double hitChance)
        {
            Random random = new Random();

            bool isHit = random.Next(100) <= hitChance;

            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 6);
            return isHit;
        }

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
