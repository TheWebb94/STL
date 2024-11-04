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

            int playerPositionX = GetPlayerPositionX();
            int playerPositionY = 5;

            //draw border
            Console.Clear();
            DrawBorders();

            DrawPlayerShip(playerPositionX, playerPositionY);
            // draw enemy
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
            Console.WriteLine("!");

            Console.ReadKey();
        }

        private static void DrawPlayerShip(int playerPositionX, int playerPositionY)
        {
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

        private static int GetPlayerPositionX()
        {
            Console.WriteLine("PLayer position x");
            if (int.TryParse(Console.ReadLine(), out int resultX))
            {
                return resultX;
            }
            return 0;
        }

        private static void DrawBorders()
        {
            for (int x = 1; x < 80; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("_");

                Console.SetCursorPosition(x, 20);
                Console.Write("_");
            }
            for (int y = 1; y < 21; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("|");

                Console.SetCursorPosition(80, y);
                Console.Write("|");
            }
        }
    }
}