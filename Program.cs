using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*to be done:
    enemy ship spawns in a random location

*/
namespace STL___Slower_Than_Light
{
    internal class Program
    {
        static void Main()
        {
            //Draw main menu 
            Draw.TitleScreen();
            MenuOptions.SetCursorLocationTitleMenu();

            string menuChoice = GetPlayerChoice.PlayerEntry();

            switch (menuChoice)

            {
                case "1":
                    Console.Clear();
                    Draw.Scenario();
                    break;
            }
            Console.ReadLine();
        }
    }
}