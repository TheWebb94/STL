using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Hangar
    {
        public static void LaunchHangar()
        {
            Console.Clear();
            DrawUI.Hangar();
            
            var playerShip = new Spaceship(ShipType.Player);
            playerShip.DrawShip();

          //  var droneShip = new Spaceship(ShipType.Drone); 
          //  droneShip.DrawShip();   

            MenuOptions.HangerMenuOptions();
            MenuOptions.SetCursorLocationHangarMenu();

            Console.ReadLine();
            Console.Clear();

        }
    }
}
