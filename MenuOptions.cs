using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class MenuOptions
    {
        public static void TitleMenuOptions()
        {
            Console.SetCursorPosition(2, 23);
            Console.WriteLine("1. Start Game");
            Console.SetCursorPosition(2, 24);
            Console.WriteLine("2. Hangar");
            Console.SetCursorPosition(2, 25);
            Console.WriteLine("3. Exit Game");
        }

        public static void SetCursorLocationTitleMenu()
        {
            Console.SetCursorPosition(3, 26);
        }

        public static void HangerMenuOptions()
        {
            Console.SetCursorPosition(3, 23);
            Console.WriteLine("Customise which module:");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("1. Engines");
            Console.SetCursorPosition(3, 25);
            Console.WriteLine("2. Hull");
            Console.SetCursorPosition(3, 26);
            Console.WriteLine("3. Weapons");
            Console.SetCursorPosition(3, 27);
            Console.WriteLine("4. Cockpit");

        }
        public static void SetCursorLocationHangarMenu()
        {
            Console.SetCursorPosition(3, 28);
        }

    }

}
