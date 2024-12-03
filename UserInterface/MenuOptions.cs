using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class MenuOptions
    {

        /// <summary>
        /// Draws the text for the main title menu options
        /// </summary>
        public static void TitleMenuOptions()
        {
            Console.SetCursorPosition(2, 22);
            Console.WriteLine("1. Start Game");
            Console.SetCursorPosition(2, 23);
            Console.WriteLine("2. Hangar");
            Console.SetCursorPosition(2, 24);
            Console.WriteLine("3. Exit Game");
        }


        /// <summary>
        /// Draws the text foir the main hangar menu options
        /// </summary>
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
        /// Method used to take valid inputs for different sized menus.
        /// </summary>
        /// <param name="menuToNavigate">input the panel you are entering a vule in to</param>
        /// <param name="validOptions">create an instance of a new list to give the valid options to take from the user</param>
        /// <returns>the validated user input</returns>
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
        /// <param name="menu">menu panel you are setting the cursor position to</param>
        /// <param name="offsetX">how many columns you want to offset the default position by</param>
        /// <param name="offsetY">how many rows you want to offset the defauult position by</param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Provides the text for the engine cuustomisation menuu
        /// </summary>
        internal static void EngineOptions()
        {
            int offsetY = 0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which engine would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 1);
            Console.WriteLine($"1. {ShipEngineLevel.Thrusters}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 2);
            Console.WriteLine($"2. {ShipEngineLevel.DoubleBoosters}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 3);
            Console.WriteLine($"3. {ShipEngineLevel.HyperDrive}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 5);

        }


        /// <summary>
        /// provides the text for the hull customisation menu
        /// </summary>
        internal static void HullOptions()
        {
            int offsetY = 0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which hull would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 1);
            Console.WriteLine($"1. {ShipHullLevel.Basic}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 2);
            Console.WriteLine($"2. {ShipHullLevel.Reinforced}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 3);
            Console.WriteLine($"3. {ShipHullLevel.HeavilyArmoured}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 5);
        }

        /// <summary>
        /// provides the text for the weapon customisation menu
        /// </summary>
        internal static void WeaponOptions()
        {
            int offsetY = 0;
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY);
            Console.WriteLine("Which weapon would you like to install?");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 1);
            Console.WriteLine($"1. {ShipWeapons.Laser}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 2);
            Console.WriteLine($"2. {ShipWeapons.Missile}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 3);
            Console.WriteLine($"3. {ShipWeapons.Beam}");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 4);
            Console.WriteLine("4. Exit");
            ResetCursorPosition(MenuNames.Hangar, 0, offsetY + 5);
        }

        /// <summary>
        /// provides the text for the players turn when in the combat scenario
        /// </summary>
        public static void DrawPlayerTurnOptions()
        {

            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
            Console.WriteLine("Your turn!, choose which component of enemy ship to target:");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 1);
            Console.WriteLine("1. Engines       ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 2);
            Console.WriteLine("2. Hull        ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 3);
            Console.WriteLine("3. Weapons       ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 4);
            Console.WriteLine("4. Cockpit       ");
        }

        /// <summary>
        /// clears the text in the menu panel
        /// </summary>
        internal static void ClearMenuPanel()
        {
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 0);
            Console.WriteLine("                                                                                                ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 1);
            Console.WriteLine("                                                                                                    ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 2);
            Console.WriteLine("                                                                                                    ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 3);
            Console.WriteLine("                                                                                                    ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 4);
            Console.WriteLine("                                                                                                    ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 5);
            Console.WriteLine("                                                                                                    ");
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 0, 6);
            Console.WriteLine("                                                                                                    ");

        }

        /// <summary>
        /// Creates a prompt for the player to continue, this effectively works as the passing of time in the combat scenario so the playerr can progress throguh the steps
        /// </summary>
        internal static void PressToContinue()
        {
            MenuOptions.ResetCursorPosition(MenuNames.Hangar, 70, 6);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Press any button to continue");
            Console.ReadKey();
            Console.ResetColor();
        }
    }

    /// <summary>
    /// Defines the names of different menu areas
    /// </summary>
    public enum MenuNames
    {
        Hangar,
        Title,
        Scenario,
        Stats
    }
}

