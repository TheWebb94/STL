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
            bool inHangar = true;

           
            Console.Clear();
            DrawUI.Hangar();

            // BUG this is an instance of the playership, i think this is different to the players ship used in the scenario
            var playerShip = new Spaceship(ShipType.Player);
            playerShip.DrawShip();

            MenuOptions.HangerMenuOptions();
            MenuOptions.SetCursorLocationHangarMenu();

            while (inHangar)
            {

            }



        }

    }
}

 
