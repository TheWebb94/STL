using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            DrawPanel(PanelOptions.titleMenu);
            Console.ResetColor();
            MenuOptions.ResetCursorPosition(MenuNames.Title);
        }

        public static void Scenario()
        {
            DrawPanel(PanelOptions.action);
            DrawPanel(PanelOptions.stats);
            DrawPanel(PanelOptions.menu);
            Starfield();
        }
        public static void Hangar()
        {
            DrawPanel(PanelOptions.action);
            DrawPanel(PanelOptions.menu);
            DrawPanel(PanelOptions.stats);
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
        public static void DrawPanel(PanelOptions panelToDraw)
        {

            int panelWidth = 0;
            int panelHeight = 0;
            int panelPositionX = 0;
            int panelPositionY = 0;

            switch (panelToDraw)
            {
                case PanelOptions.menu:
                    panelWidth = 116;
                    panelHeight = 9;
                    panelPositionX = 0;
                    panelPositionY = 21;
                    break;
                case PanelOptions.titleMenu:
                    panelWidth = 90;
                    panelHeight = 9;
                    panelPositionX = 0;
                    panelPositionY = 21;
                    break;
                case PanelOptions.action:
                    panelWidth = 90;
                    panelHeight = 20;
                    panelPositionX = 0;
                    panelPositionY = 0;
                    break;
                case PanelOptions.stats:
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

            // Create a starfield effect by drawing stars randomly in the space the action panel is drawn
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

        // Draws ASCII end screen created using online ACII art generator https://patorjk.com/software/taag/#p=display&f=Graffiti&t=STL
        internal static void GameVictory()
        {
            int logoPositionX = 22;
            int logoPositionY = 3;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(logoPositionX, logoPositionY);
            Console.WriteLine(" ____   ____.__        __                       ._.");
            Console.SetCursorPosition(logoPositionX, logoPositionY + 1);
            Console.WriteLine("\\   \\ /   /|__| _____/  |_  ___________ ___.__.| |");
            Console.SetCursorPosition(logoPositionX, logoPositionY + 2);
            Console.WriteLine(" \\   Y   / |  |/ ___\\   __\\/  _ \\_  __ <   |  || |");
            Console.SetCursorPosition(logoPositionX, logoPositionY + 3);
            Console.WriteLine("  \\     /  |  \\  \\___|  | (  <_> )  | \\/\\___  | \\|");
            Console.SetCursorPosition(logoPositionX, logoPositionY + 4);
            Console.WriteLine("   \\___/   |__|\\___  >__|  \\____/|__|   / ____| __");
            Console.SetCursorPosition(logoPositionX, logoPositionY + 5);
            Console.WriteLine("                   \\/                   \\/      \\/");

            MenuOptions.PressToContinue();
            Console.Clear();

        }

        // Draws ASCII end screen created using online ACII art generator https://patorjk.com/software/taag/#p=display&f=Graffiti&t=STL
        internal static void GameOver()
        {
            int logoPositionX = 22;
            int logoPositionY = 3;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(logoPositionX, logoPositionY);
            Console.WriteLine("  ________                        ________                     ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+1);
            Console.WriteLine(" /  _____/_____    _____   ____   \\_____  \\___  __ ___________ ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+2);
            Console.WriteLine("/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\");
            Console.SetCursorPosition(logoPositionX, logoPositionY+3);
            Console.WriteLine("\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/");
            Console.SetCursorPosition(logoPositionX, logoPositionY+4);
            Console.WriteLine(" \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   ");
            Console.SetCursorPosition(logoPositionX, logoPositionY+5);
            Console.WriteLine("        \\/     \\/      \\/     \\/          \\/          \\/       ");

            MenuOptions.PressToContinue();
            Console.Clear();

        }
    }
    public enum PanelOptions
    {
        stats,
        action,
        menu,
        titleMenu
    }
}
