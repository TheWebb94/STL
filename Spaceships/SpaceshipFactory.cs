using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    /// <summary>
    /// factory pattern for building new enemy spaceships, this was originally going to be used to spawn multiple enemy spaceships in a given scenario but this functionality ended up not being used to time constraints
    /// factory pattern adapted from https://www.youtube.com/watch?v=SLEu6rNdJj0&ab_channel=campbelltech
    /// </summary>
    internal class SpaceshipFactory

    {
        public Spaceship SpawnSpaceShip(ShipType shipType)
        {
            Spaceship spaceship;

            switch (shipType)
            {
                case ShipType.Player:
                    spaceship = new Spaceship(shipType, ShipWeapons.Laser, ShipHullLevel.Basic, ShipEngineLevel.Thrusters);
                    break;

                case ShipType.Drone:
                    spaceship = new Spaceship(shipType, ShipWeapons.Laser, ShipHullLevel.Drone, ShipEngineLevel.Drone);
                    break;

                default:
                    throw new NotImplementedException("ShipType not supported");
            }

            return spaceship;
        }
    }
}

