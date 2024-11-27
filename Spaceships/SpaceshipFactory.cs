using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
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
                        throw new NotImplementedException("ShipType not registered");
                }

                return spaceship;
            }
        }
    }

