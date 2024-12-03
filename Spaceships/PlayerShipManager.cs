using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light.Spaceships
{
    /// <summary>
    /// Class for containing the player ship, this has been made static so the user can access and modify this ship in all parts of the application without having to pass around an object of the ship throguh vbarios methods
    /// </summary>
    internal static class PlayerShipManager
    {
        public static Spaceship playerSpaceship = new Spaceship(ShipType.Player, ShipWeapons.Laser, ShipHullLevel.Basic, ShipEngineLevel.Thrusters);

    }
}

