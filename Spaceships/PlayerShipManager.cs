using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light.Spaceships
{
    internal static class PlayerShipManager
    {
        public static Spaceship playerSpaceship = new Spaceship(ShipType.Player, ShipWeapons.Laser, ShipHullLevel.Basic, ShipEngineLevel.Thrusters);

    }
}

