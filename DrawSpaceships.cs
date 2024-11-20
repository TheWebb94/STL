using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class SpaceShipFactory
    {
        public Spaceship SpawnSpaceShip(ShipType shipType)
        {
            Spaceship spaceship;

            switch(shipType)
            {
                case ShipType.Player:
                    spaceship = new Spaceship(shipType, ShipWeapons.Laser, ShipHullLevel.Basic, ShipEngineLevel.Thrusters);
                    break;
                    
                case ShipType.Drone:
                    spaceship = new Spaceship(shipType);
                    break;

                default:
                    throw new NotImplementedException("ShipType not registered");
            }

            return spaceship;
        }
    }

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


        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }

        // constructor that sets default values for ship type and location
        public Spaceship(ShipType shipType, ShipWeapons weapon = ShipWeapons.none, ShipHullLevel hull = ShipHullLevel.Basic, ShipEngineLevel engine = ShipEngineLevel.Thrusters)
        {
            _shipType = shipType;
            Weapon = weapon;
            Hull = hull;
            Engine = engine;
            SetShipLocation();
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

    }

    public enum ShipType
    {
        Player,
        Drone,
        Missile
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
        HeavilyArmoured
    }

    public enum ShipEngineLevel
    {
        Thrusters,
        DoubleBoosters,
        HyperDrive
    }

}
