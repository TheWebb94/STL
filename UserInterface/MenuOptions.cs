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

        public static void HangerMenuOptions()
        {
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("Customise which module:");
            Console.SetCursorPosition(3, 23);
            Console.WriteLine("1. Engines");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("2. Hull");
            Console.SetCursorPosition(3, 25);
            Console.WriteLine("3. Weapons");
            Console.SetCursorPosition(3, 26);
            Console.WriteLine("4. Exit to main menu");

            ResetCursorPosition(MenuNames.Hangar, 5);
        }
        /// <summary>
        /// Gets an input from the user
        /// </summary>
        /// <param name="menuToNavigate">enterr which menu you are overwriting</param>
        /// <param name="validOptions">'new List<char> ' then list the options the player can enter, typically, 1-x</param>
        /// <returns>the valid character the user has entered</returns>
        public static char PlayerEntry(MenuNames menuToNavigate, List<char> validOptions)
        {
            ResetCursorPosition(menuToNavigate);

            char userInput;

            while (true)
            {

                userInput = Console.ReadKey(true).KeyChar;

                if (validOptions.Contains(userInput))
                {
                    return userInput;
                }
                else
                {
                    ResetCursorPosition(menuToNavigate);
                    Console.WriteLine("                  ");
                }
            }
        }
        /// <summary>
        /// Method for setting the cursor position to a specific menu.  default is in position 1,1 of the selected panel
        /// </summary>
        /// <param name="menu">enter the menu you are setting the cursor position for</param>
        /// <param name="offsetX">how much do you want to offset x position by</param>
        /// <param name="offsetY">how much you want to offset y polsition by</param>
        /// <exception cref="NotImplementedException"></exception>
        public static void ResetCursorPosition(MenuNames menu, int offsetX = 0, int offsetY = 0)
        {
            int cursorPostitionX;
            int cursorPostitionY;

            switch (menu)
            {
                case MenuNames.Hangar:
                    cursorPostitionX = 3;
                    cursorPostitionY = 22;
                    Console.SetCursorPosition(cursorPostitionX + offsetX, cursorPostitionY + offsetY);
                    break;
                case MenuNames.Title:
                    cursorPostitionX = 3;
                    cursorPostitionY = 22;
                    Console.SetCursorPosition(cursorPostitionX + offsetX, cursorPostitionY + offsetY);
                    break;
                case MenuNames.Scenario:
                    cursorPostitionX = 0;
                    cursorPostitionY = 0;
                    Console.SetCursorPosition(cursorPostitionX + offsetX, cursorPostitionY + offsetY);
                    break;
                case MenuNames.Stats:
                    cursorPostitionX = 94;
                    cursorPostitionY = 1;
                    Console.SetCursorPosition(cursorPostitionX + offsetX, cursorPostitionY + offsetY);
                    break;
                default:
                    throw new Exception();
            }
        }

        internal static void EngineOptions()
        {
            //  ClearMenuPanel();
            int offsetY =0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which engine would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+1);
            Console.WriteLine($"1. {ShipEngineLevel.Thrusters}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+2);
            Console.WriteLine($"2. {ShipEngineLevel.DoubleBoosters}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+3);
            Console.WriteLine($"3. {ShipEngineLevel.HyperDrive}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+5);

        }

        internal static void HullOptions()
        {
            int offsetY = 0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which hull would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+1);
            Console.WriteLine($"1. {ShipHullLevel.Basic}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+2);
            Console.WriteLine($"2. {ShipHullLevel.Reinforced}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+3);
            Console.WriteLine($"3. {ShipHullLevel.HeavilyArmoured}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+5);

        }

        internal static void WeaponOptions()
        {
            int offsetY = 0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which weapon would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+1);
            Console.WriteLine($"1. {ShipWeapons.Laser}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+2);
            Console.WriteLine($"2. {ShipWeapons.Missile}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+3);
            Console.WriteLine($"3. {ShipWeapons.Beam}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY+5);
        }
    }
}
    
public enum MenuNames
    {
        Hangar,
        Title,
        Scenario,
        Stats
    }

