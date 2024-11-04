using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Program
    {
        static void Main()
        {

            Console.Clear();

            //draw border
            DrawActionPanel();
            DrawStatPanel();
            DrawMenuPanel();

            //Draw player ship
            DrawPlayerShip();

            // draw enemy
            DrawDrone();

            //Console.SetCursorPosition(playerPositionX, playerPositionY);
            //Console.Write(">==>\n");
            //Console.SetCursorPosition(playerPositionX, playerPositionY + 1);
            //Console.Write("  [OOO]>\n");
            //Console.SetCursorPosition(playerPositionX, playerPositionY + 2);
            //Console.Write(" ={000][][]>\n");
            //Console.SetCursorPosition(playerPositionX, playerPositionY + 3);
            //Console.Write("  [OOO]>\n");
            //Console.SetCursorPosition(playerPositionX, playerPositionY + 4);
            //Console.Write(">==>\n");
            // draw stats
            //


            Console.ReadKey();
        }


        private static void DrawActionPanel()
        {
            // Draw horizontal borders
            Console.SetCursorPosition(0, 0);
            Console.Write("\u250C"); // Top left corner
            for (int x = 1; x < 90; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("\u2500");
            }
            Console.SetCursorPosition(90, 0);
            Console.Write("\u2510"); // Top right corner

            // Draw vertical borders
            for (int y = 1; y < 20; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(90, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw bottom borders
            Console.SetCursorPosition(0, 20);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = 1; x < 90; x++)
            {
                Console.SetCursorPosition(x, 20);
                Console.Write("\u2500"); // Horizontal line
            }
            Console.SetCursorPosition(90, 20);
            Console.Write("\u2518"); // Bottom right corner
        }

        private static void DrawStatPanel()
        {
            // Draw horizontal borders
            Console.SetCursorPosition(93, 0);
            Console.Write("\u250C"); // Top left corner
            for (int x = 94; x < 115; x++)
            {
                Console.SetCursorPosition(x, 0); // Top horizontal line
                Console.Write("\u2500");
            }
            Console.SetCursorPosition(115, 0);
            Console.Write("\u2510"); // Top right corner

            // Draw vertical borders
            for (int y = 1; y < 20; y++)
            {
                Console.SetCursorPosition(93, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(115, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw bottom borders
            Console.SetCursorPosition(93, 20);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = 94; x < 115; x++)
            {
                Console.SetCursorPosition(x, 20); //bottoom horizontal line
                Console.Write("\u2500");
            }
            Console.SetCursorPosition(115, 20);
            Console.Write("\u2518"); // Bottom right corner
        }

        private static void DrawMenuPanel()
        {
            int bottomPanelYStart = 21; // Starting position below existing panels
            int panelWidth = 116; // Total width (90 + 26 for the stat panel)

            // Draw the top border of the bottom panel
            Console.SetCursorPosition(0, bottomPanelYStart);
            Console.Write("\u250C"); // Top left corner
            for (int x = 1; x < panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, bottomPanelYStart);
                Console.Write("\u2500");
            }
            Console.SetCursorPosition(panelWidth - 1, bottomPanelYStart);
            Console.Write("\u2510"); // Top right corner

            // Draw the vertical borders
            for (int y = bottomPanelYStart + 1; y < bottomPanelYStart + 8; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("\u2502"); // Left vertical line

                Console.SetCursorPosition(panelWidth - 1, y);
                Console.Write("\u2502"); // Right vertical line
            }

            // Draw the bottom border
            Console.SetCursorPosition(0, bottomPanelYStart + 8);
            Console.Write("\u2514"); // Bottom left corner
            for (int x = 1; x < panelWidth - 1; x++)
            {
                Console.SetCursorPosition(x, bottomPanelYStart + 8);
                Console.Write("\u2500"); // Bottom horizontal line
            }
            Console.SetCursorPosition(panelWidth - 1, bottomPanelYStart + 8);
            Console.Write("\u2518"); // Bottom right corner
        }

        private static void DrawPlayerShip()
        { 
            int playerPositionX = 5;
            int playerPositionY = 8;
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(">==>\n");
            Console.SetCursorPosition(playerPositionX, playerPositionY + 1);
            Console.Write("  [OOO]>\n");
            Console.SetCursorPosition(playerPositionX, playerPositionY + 2);
            Console.Write(" ={000][][]>\n");
            Console.SetCursorPosition(playerPositionX, playerPositionY + 3);
            Console.Write("  [OOO]>\n");
            Console.SetCursorPosition(playerPositionX, playerPositionY + 4);
            Console.Write(">==>\n");
        }
        private static void DrawDrone()
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
    }
}