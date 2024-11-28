using System;
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
            Starfield();
            MenuOptions.TitleMenuOptions();
            Console.ForegroundColor = ConsoleColor.Blue;
            Logo();
            DrawPanel("titleMenu");
            Console.ResetColor();
            MenuOptions.SetCursorLocationTitleMenu();
        }

        public static void Scenario()
        {
            DrawPanel("action");
            DrawPanel("stats");
            DrawPanel("menu");
            Starfield();
        }
        public static void Hangar()
        {
            DrawPanel("action");
            DrawPanel("titleMenu");
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


        public static void DrawPanel(string panelToDraw)
        {

            int panelWidth = 0;
            int panelHeight = 0;
            int panelPositionX = 0;
            int panelPositionY = 0;

            switch (panelToDraw)
            {
                case "menu":
                    panelWidth = 116;
                    panelHeight = 9;
                    panelPositionX = 0;
                    panelPositionY = 21;
                    break;
                case "titleMenu":
                    panelWidth = 90;
                    panelHeight = 9;
                    panelPositionX = 0;
                    panelPositionY = 21;
                    break;
                case "action":
                    panelWidth = 90;
                    panelHeight = 20;
                    panelPositionX = 0;
                    panelPositionY = 0;
                    break;
                case "stats":
                    panelWidth = 22;
                    panelHeight = 20;
                    panelPositionX = 93;
                    panelPositionY = 0;
                    break;
                default:
                    break;
            }


            // Draw the top border
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(panelPositionX, panelPositionY);
            Console.Write("\u250C"); // Top left corner
            for (int x = panelPositionX + 1; x < panelPositionX + panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, panelPositionY);
                Console.Write("\u2500"); // Top horizontal line
            }
            Console.SetCursorPosition(panelPositionX + panelWidth-1, panelPositionY);
            Console.Write("\u2510"); // Top right corner

            // Draw vertical borders
            for (int y = panelPositionY + 1; y < panelPositionY + panelHeight - 1; y++) // Start from y + 1
            {
                Console.SetCursorPosition(panelPositionX, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(panelPositionX + panelWidth - 1, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw the bottom border
            Console.SetCursorPosition(panelPositionX, panelPositionY + panelHeight-1);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = panelPositionX + 1; x < panelPositionX + panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, panelPositionY + panelHeight - 1);
                Console.Write("\u2500"); // Bottom horizontal line
            }
            Console.SetCursorPosition(panelPositionX + panelWidth - 1, panelPositionY + panelHeight-1);
            Console.Write("\u2518"); // Bottom right corner
            Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write('*');
                    }
                }
            }
        }
    }
}
