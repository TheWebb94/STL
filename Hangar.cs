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
            DrawSpaceships.PlayerShip();
            MenuOptions.HangerMenuOptions();
            MenuOptions.SetCursorLocationHangarMenu();
        }
    }
}
