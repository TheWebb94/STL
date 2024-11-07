using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class DrawSpaceships
    {
        public static void PlayerShip()
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
    }
}
