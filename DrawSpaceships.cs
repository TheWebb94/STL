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
                    spaceship = new Spaceship(shipType);
                    break;

                case ShipType.Drone:
                    spaceship = new Spaceship(shipType);
                    break;

                default:
                    throw new NotImplementedException("ShipType not registered");
            }

            ActiveShipManager.AddSpaceship(spaceship);

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

        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }

        // constructor that sets default values for ship type and location
        public Spaceship(ShipType shipType)
        {
            _shipType = shipType;
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
            Console.Write(">==>");
            Console.Write("\n");
            Console.SetCursorPosition(_positionX, _positionY + 1);
            Console.Write("  [OOO]>\n");
            Console.SetCursorPosition(_positionX, _positionY + 2);
            Console.Write(" ={000][][]>\n");
            Console.SetCursorPosition(_positionX, _positionY + 3);
            Console.Write("  [OOO]>\n");
            Console.SetCursorPosition(_positionX, _positionY + 4);
            Console.Write(">==>\n");
        }

        private void DrawDroneShip()
        {
            Console.SetCursorPosition(_positionX, _positionY);
            Console.Write("--==--\n");
            Console.SetCursorPosition(_positionX, _positionY + 1);
            Console.Write("[|||] \n");
            Console.SetCursorPosition(_positionX, _positionY + 2);
            Console.Write(" {00} \n");
            Console.SetCursorPosition(_positionX, _positionY + 3);
            Console.Write("[|||] \n");
            Console.SetCursorPosition(_positionX, _positionY + 4);
            Console.Write("--==--\n");
        }

    }

    public enum ShipType
    {
        Player,
        Drone,
        Missile
    }
}
