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
        public int WeaponSize { get; private set; }
        public int HullSize { get; private set; }
        public int CockpitSize { get; private set; }
        public int Health { get; private set; }



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

            switch (_shipType)
            {
                case ShipType.Player:
                    Health = 100;
                    break;
                case ShipType.Drone:
                    Health = 50;
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (Engine)
            {
                case ShipEngineLevel.Thrusters:
                    DodgeChance = 10;
                    EngineSize = 2;
                    break;

                case ShipEngineLevel.DoubleBoosters:
                    DodgeChance = 25;
                    EngineSize = 4;
                    break;

                case ShipEngineLevel.HyperDrive:
                    DodgeChance = 40;
                    EngineSize = 5;
                    break;

                case ShipEngineLevel.Drone:
                    DodgeChance = 30;
                    EngineSize = 2;
                    break;

                default:
                    throw new NotImplementedException();
            }

            switch (Weapon)
            {
                case ShipWeapons.Laser:
                    Accuracy = 75;
                    Damage = 25;
                    WeaponSize = 2;
                    break;
                case ShipWeapons.Missile:
                    Accuracy = 50;
                    Damage = 75;
                    WeaponSize = 4;
                    break;
                case ShipWeapons.Beam:
                    Accuracy = 90;
                    Damage = 40;
                    WeaponSize = 4;
                    break;
                default : 
                    throw new NotImplementedException();
            }

            switch (Hull)
            {
                case ShipHullLevel.Basic:
                    Armour = 0;
                    HullSize = 4;
                    break;
                case ShipHullLevel.Reinforced:
                    Armour = 10;
                    HullSize = 5;
                    break;
                case ShipHullLevel.HeavilyArmoured:
                    Armour = 20;
                    HullSize = 6;
                    break;
                case ShipHullLevel.Drone:
                    Armour = 10;    
                    HullSize = 4;
                    break;
                default:
                    throw new NotImplementedException();
            }
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
                Console.WriteLine($"Ship Type:    {_shipType}");
                offsetY++;
            }
            MenuOptions.ResetCursorPosition(MenuNames.Stats, 0, offsetY + 1);
            Console.WriteLine($"Health:      {Health} ");
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

}
