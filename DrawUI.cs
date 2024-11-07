﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class DrawUI
    {
        public static void TitleScreen()
        {
            DrawUI.Starfield();
            MenuOptions.TitleMenuOptions();
            Console.ForegroundColor = ConsoleColor.Blue;
            Logo();
            MenuPanel();
            Console.ResetColor();
            MenuOptions.SetCursorLocationTitleMenu();
        }

        public static void Scenario()
        {
            ActionPanel();
            StatPanel();
            MenuPanel();
            Starfield();
        }
        public static void Hangar()
        {
            ActionPanel();
            MenuPanel(true);
        }

        /// <summary>
        /// Draws logo for game, logo created using online ACII art generator https://patorjk.com/software/taag/#p=display&f=Graffiti&t=STL
        /// </summary>
        public static void Logo()
        {
            int logoPositionX = 35;
            int logoPositionY = 3;
            Console.SetCursorPosition(logoPositionX, logoPositionY);
            Console.WriteLine("  ____________________.____     ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+1);
            Console.WriteLine(" /   _____/\\__    ___/|    |    ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+2);
            Console.WriteLine(" \\_____  \\   |    |   |    |    ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+3);
            Console.WriteLine(" /        \\  |    |   |    |___ ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+4);
            Console.WriteLine("/_______  /  |____|   |_______ \\");
            Console.SetCursorPosition(logoPositionX, logoPositionY+5);
            Console.WriteLine("        \\/                    \\/");
        }

        private static void ActionPanel()
        {
            int panelWidth = 90;
            int panelHeight = 20;

            // Draw the top border
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.SetCursorPosition(0, 0);
            Console.Write("\u250C"); // Top left corner
            for (int x = 1; x < panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("\u2500"); // Top horizontal line
            }
            Console.SetCursorPosition(panelWidth - 1, 0);
            Console.Write("\u2510"); // Top right corner

            // Draw vertical borders
            for (int y = 1; y < panelHeight; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(panelWidth - 1, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw the bottom border
            Console.SetCursorPosition(0, panelHeight);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = 1; x < panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, panelHeight);
                Console.Write("\u2500"); // Bottom horizontal line
            }
            Console.SetCursorPosition(panelWidth - 1, panelHeight);
            Console.Write("\u2518"); // Bottom right corner
            Console.ResetColor();
        }

        private static void StatPanel()
        {
            int panelWidth = 22;
            int panelHeight = 20;
            int startX = 93;

            // Panel Title message
            Console.SetCursorPosition(startX + 1, 1);
            Console.WriteLine("Stats");

            // Draw the top border
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(startX, 0);
            Console.Write("\u250C"); // Top left corner
            for (int x = startX + 1; x < startX + panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("\u2500"); // Top horizontal line
            }
            Console.SetCursorPosition(startX + panelWidth - 1, 0);
            Console.Write("\u2510"); // Top right corner

            // Draw vertical borders
            for (int y = 1; y < panelHeight; y++)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(startX + panelWidth - 1, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw the bottom border
            Console.SetCursorPosition(startX, panelHeight);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = startX + 1; x < startX + panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, panelHeight);
                Console.Write("\u2500"); // Bottom horizontal line
            }
            Console.SetCursorPosition(startX + panelWidth - 1, panelHeight);
            Console.Write("\u2518"); // Bottom right corner
            Console.ResetColor();
        }

        private static void MenuPanel(bool isDrawingHangarMenu = false)
        {
            int panelWidth = 116;
            int panelHeight = 9;
            int startY = 21;

            if (isDrawingHangarMenu == true)
            {
                 panelWidth = 90;
            }

            //Panel title message
            Console.ResetColor();
            Console.SetCursorPosition(2,22);
            Console.WriteLine("Menu");


            // Draw the top border
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, startY);
            Console.Write("\u250C"); // Top left corner
            for (int x = 1; x < panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, startY);
                Console.Write("\u2500"); // Top horizontal line
            }
            Console.SetCursorPosition(panelWidth - 1, startY);
            Console.Write("\u2510"); // Top right corner
            Console.ResetColor();

            // Draw vertical borders
            for (int y = startY + 1; y < startY + panelHeight - 1; y++)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.SetCursorPosition(0, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(panelWidth - 1, y);
                Console.Write("\u2502"); // Right vertical line


                // Draw the bottom border
                Console.SetCursorPosition(0, startY + panelHeight - 1);
                Console.Write("\u2514"); // Bottom left corner
                for (int x = 1; x < panelWidth - 1; x++)
                {
                    Console.SetCursorPosition(x, startY + panelHeight - 1);
                    Console.Write("\u2500"); // Bottom horizontal line
                }
                Console.SetCursorPosition(panelWidth - 1, startY + panelHeight - 1);
                Console.Write("\u2518"); // Bottom right corner
                Console.ResetColor();
            }
        }

        

        public static void Drone()
        {
            int dronePositionX = 75;
            int dronePositionY = 8;
            Console.SetCursorPosition(dronePositionX, dronePositionY);
            Console.Write("  --==--  \n");
            Console.SetCursorPosition(dronePositionX, dronePositionY + 1);
            Console.Write("  [|||]   \n");
            Console.SetCursorPosition(dronePositionX, dronePositionY + 2);
            Console.Write("   {00}   \n");
            Console.SetCursorPosition(dronePositionX, dronePositionY + 3);
            Console.Write("  [|||]   \n");
            Console.SetCursorPosition(dronePositionX, dronePositionY + 4);
            Console.Write("  --==--  \n");
        }

        public static void Starfield()
        {
            Random rand = new Random();
            int screenWidth = 89;
            int screenHeight = 19;

            // Create a starfield effect by drawing stars randomly on the console
            for (int y = 1; y < screenHeight; y++)
            {
                for (int x = 1; x < screenWidth; x++)
                {

                    if (rand.Next(0, 100) < 3) // Chance to draw a star
                    {
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = ConsoleColor.White; // Set star color
                        Console.Write('*');
                    }
                }
            }
        }
    }
}