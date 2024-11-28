using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal static class ActiveShipManager
    {
        public static List<Spaceship> spaceships = new List<Spaceship>();

        public static void AddSpaceship(Spaceship spaceship) { 
            spaceships.Add(spaceship);
        }

        public static void RemoveSpaceship(Spaceship spaceship) {
            spaceships.Remove(spaceship);
        } 
    }
}
