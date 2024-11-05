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
    }
}
